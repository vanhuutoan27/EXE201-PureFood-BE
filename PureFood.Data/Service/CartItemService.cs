﻿using AutoMapper;
using PureFood.Core.Models;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;

using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class CartItemService : ICartItemService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CartItemService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> DeleteCartItem(Guid cartItemId)
        {
            var cartItem = await _repositoryManager.CartItemRepository.GetByIdAsync(cartItemId);
            if (cartItem == null)
            {
                throw new Exception("Không tìm thấy sản phẩm giỏ hàng.");
            }
            _repositoryManager.CartItemRepository.Remove(cartItem);
            await _repositoryManager.SaveAsync();
            return true;
        }
        public async Task<PageResult<CartItemResponee>> GetAllCartItemByUser(Guid UserId, int page, int limit)
        {
            // Retrieve paginated cart items from the repository
            var paginatedCar = await _repositoryManager.CartItemRepository.GetAllCartItemByUserAsync(page, limit, UserId);

            // Create a list to hold the response items
            var CartResponse = new List<CartItemResponee>();

            // Loop through each item in paginatedCar and map to CartItemRespone
            foreach (var item in paginatedCar.Items)
            {
                CartResponse.Add(new CartItemResponee
                {
                    CartItemId = item.CartItemId,
                    ProductId = item.ProductId,
                    ProductName = item.Product?.ProductName,
                    Category = item.Product?.Category.CategoryName,
                    Slug = item.Product?.Slug,
                    Quantity = item.Quantity,
                    Price = item.Product?.Price ?? 0,
                    Weight = item.Product?.Weight ?? 0,
                    Unit = item.Product?.Unit,
                    Origin = item.Product?.Origin,
                    Organic = item.Product?.Organic,
                    Image = new List<string> { item.Product?.Images.Select(u => u.Url).FirstOrDefault() ?? string.Empty },
                    Status = item.Product?.Status
                });
            }

            // Construct the PageResult response with mapped items and pagination info
            var pageResult = new PageResult<CartItemResponee>
            {
                Items = CartResponse, // The list of mapped cart items
                CurrentPage = page, // Assuming paginatedCar has these properties
                TotalPages = (int)Math.Ceiling(paginatedCar.TotalCount / (double)limit),
                TotalItems = paginatedCar.TotalCount
            };

            return pageResult;
        }


        public async Task<bool> UpdateCartItem(Guid cartItemId, int Quantity)
        {
            var cartItem = await _repositoryManager.CartItemRepository.GetByIdAsync(cartItemId);
            if (cartItem == null)
            {
                throw new Exception("Không tìm thấy sản phẩm giỏ hàng.");
            }
            cartItem.Quantity = Quantity;
            _repositoryManager.CartItemRepository.Update(cartItem);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
