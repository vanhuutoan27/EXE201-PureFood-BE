using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;
using System.Collections.Generic;

namespace PureFood.Data.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public SupplierService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> createSupplier(CreateSupplierRequest review)
        {
         /*   var getProduct = await _repositoryManager.ReviewRepository.GetReviewByProductId(review.ProductId);
            if (getProduct == null)
            {
                throw new Exception("Not found product");
            }*/
          /*  var getUser = await _repositoryManager.SuppliewReRepository.GetByIdAsync(review.);
            if (getUser == null)
            {
                throw new Exception("Not Found User");
            }*/
            try
            {
                var newReview = new Supplier
                {
                    SupplierId = Guid.NewGuid(),
                    Address= review.Address,
                    CreatedAt= DateTime.UtcNow,
                    Description= review.Description,
                    PhoneNumber= review.PhoneNumber,
                    SuplierName= review.SupplierName, 
                    
                };
                _repositoryManager.SupplierRepository.Add(newReview);
                await _repositoryManager.SaveAsync();
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB Error");

            }
            return true;
        }

        public async Task<bool> deleteSupplier(Guid id)
        {
            try
            {
                var getSupplier = await _repositoryManager.SupplierRepository.GetByIdAsync(id);
                if (getSupplier == null)
                {
                    throw new Exception("Not Found");
                }
                _repositoryManager.SupplierRepository.Remove(getSupplier);
                _repositoryManager.SaveAsync();
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB error");
            }
            return true;
        }

        public async Task<PageResult< SupplierReponse>> getAll(int page, int limit)
        {
            var supplierRepository = await _repositoryManager.SupplierRepository.GetAllSupplierAsync(page, limit);
            var totalItems = supplierRepository.Count();

            var reviewReponse = _mapper.Map<IEnumerable<SupplierReponse>>(supplierRepository);
            return new PageResult<SupplierReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = reviewReponse
            };

        }

        public async Task<SupplierReponse> getSupplierById(Guid reviewid)
        {
            var supplierRepository = await _repositoryManager.SupplierRepository.GetByIdAsync(reviewid);
            return  _mapper.Map<SupplierReponse>(supplierRepository);
        }

        public async Task<bool> updateSupplier(Guid id, CreateSupplierRequest review)
        {
            var getSupplier = await _repositoryManager.SupplierRepository.GetByIdAsync(id);

            if (review == null)
            {
                throw new Exception("Not Found");
            }
            try
            {
                getSupplier.SuplierName = review.SupplierName;
                getSupplier.Description = review.Description;
                getSupplier.Address = review.Address;
                getSupplier.PhoneNumber = review.PhoneNumber;


                _repositoryManager.SupplierRepository.Update(getSupplier);
                await _repositoryManager.SaveAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB error");

            }
        }
    }
}
