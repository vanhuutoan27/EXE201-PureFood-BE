﻿using AutoMapper;
using PureFood.Core.Domain.Content;

using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;

using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class CartService : ICartService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CartService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreateCartRequest> CreateCartAsync(CreateCartRequest request)
        {
            var existingcart = await _repositoryManager.CartRepository.GetCartByUser(request.UserId);
            Cart model;
            if (existingcart != null)
            {
                model = existingcart;
            }
            else
            {
                model = new Cart
                {
                    UserId = request.UserId
                };
                _repositoryManager.CartRepository.Add(model);
            }



            foreach (var cartItem in request.CartItems)
            {
                var existingcartItem = await _repositoryManager.CartItemRepository.GetByCartIdandProductId(model.CartId, cartItem.ProductId);
                if (existingcartItem != null)
                {
                    existingcartItem.Quantity += cartItem.Quantity;
                    _repositoryManager.CartItemRepository.Update(existingcartItem);

                }
                else
                {
                    var newcartItems = new CartItem
                    {
                        CartId = model.CartId,
                        ProductId = cartItem.ProductId,
                        Quantity = cartItem.Quantity
                    };
                    _repositoryManager.CartItemRepository.Add(newcartItems);
                }

            }
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateCartRequest>(model);
            return result;
        }
        public async Task<PageResult<CartResponse>> GetAllCartsByUser(Guid user, int itemPage, int itemLimit)
        {
            if (user == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(user), "ID không được bỏ trống.");
            }
            var paginatedCarts = await _repositoryManager.CartRepository.GetAllCartByuserAsync(0, 0, user); // No cart pagination
            if (paginatedCarts == null || !paginatedCarts.Items.Any())
            {
                return null; // Return null or handle an empty result set
            }

            var cartResponses = new List<CartResponse>();
            int totalCartItemsCount = 0;

            foreach (var cart in paginatedCarts.Items)
            {
                totalCartItemsCount += cart.CartItems.Count;
                var paginatedCartItems = cart.CartItems
                    .Skip((itemPage - 1) * itemLimit)
                    .Take(itemLimit)
                    .ToList();

                var cartItemsResponse = new List<CartItemRespone>();

                foreach (var item in paginatedCartItems)
                {
                    cartItemsResponse.Add(new CartItemRespone
                    {
                        CartItemId = item.CartItemId,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Description = item.Product?.Description,
                        Origin = item.Product?.Origin,
                        Price = item.Product?.Price ?? 0,
                        ProductName = item.Product?.ProductName,
                        Status = item.Product?.Status,
                        Unit = item.Product?.Unit,
                        Organic = item.Product?.Organic,
                        Weight = item.Product?.Weight ?? 0
                    });
                }

                cartResponses.Add(new CartResponse
                {
                    CartId = cart.CartId,
                    UserId = cart.User.Id,
                    CartItems = cartItemsResponse // Paginated cart items
                });
            }

            return new PageResult<CartResponse>
            {
                CurrentPage = itemPage,
                TotalPages = (int)Math.Ceiling(totalCartItemsCount / (double)itemLimit),
                TotalItems = totalCartItemsCount,
                Items = cartResponses
            };
        }


    }
}
