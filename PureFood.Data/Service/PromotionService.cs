using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class PromotionService : IPromotionService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public PromotionService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> ChangeStatusPromotion(Guid id)
        {
            var promotion = await _repositoryManager.PromotionRepository.GetByIdAsync(id);
            if (promotion == null)
            {
                return false;
            }
            if (promotion.Status)
            {
                promotion.Status = false;
            }
            else
            {
                promotion.Status = true;
            }
            _repositoryManager.PromotionRepository.Update(promotion);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> createPromotion(CreatePromotionRequest request)
        {
            try
            {
                var newPromotion = new Promotion
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Description = request.Description,
                    DiscountCode = request.DiscountCode,
                    DiscountPercentage = request.DiscountPercentage,
                    EndDate = request.EndDate,
                    PromotionId = Guid.NewGuid(),
                    PromotionName = request.PromotionName,
                    Quantity = request.Quantity,
                    Stock = request.Quantity,
                    StartDate = request.StartDate,
                    Status = false,
                };
                _repositoryManager.PromotionRepository.Add(newPromotion);
                await _repositoryManager.SaveAsync();
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB Error");

            }
            return true;
        }

        public async Task<bool> deletePromotion(Guid id)
        {
            try
            {
                var getPromotion = await _repositoryManager.PromotionRepository.GetByIdAsync(id);
                if (getPromotion == null)
                {
                    throw new Exception("Không tìm thấy khuyến mãi.");
                }
                _repositoryManager.PromotionRepository.Remove(getPromotion);
                _repositoryManager.SaveAsync();
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB error");
            }
            return true;
        }

        public async Task<PageResult<PromotionReponse>> getAll(int page, int limit)
        {
            var promotionRepository = await _repositoryManager.PromotionRepository.GetAllPromotionAsync(page, limit);
            var totalItems = promotionRepository.Count();

            var promotionReponse = _mapper.Map<IEnumerable<PromotionReponse>>(promotionRepository);
            return new PageResult<PromotionReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = promotionReponse
            };
        }

        public async Task<PromotionReponse> getPromotionById(Guid promotionId)
        {
            var supplierRepository = await _repositoryManager.PromotionRepository.GetByIdAsync(promotionId);
            return _mapper.Map<PromotionReponse>(supplierRepository);
        }

        public async Task<bool> updatePromotion(Guid id, UpdatePromotionRequest request)
        {
            var getPromotion = await _repositoryManager.PromotionRepository.GetByIdAsync(id);

            if (getPromotion == null)
            {
                throw new Exception("Không tìm thấy khuyến mãi.");
            }
            try
            {
                getPromotion.StartDate = request.StartDate;
                getPromotion.EndDate = request.EndDate;
                getPromotion.UpdatedAt = DateTime.Now;
                getPromotion.Description = request.Description;
                getPromotion.DiscountCode = request.DiscountCode;
                getPromotion.DiscountPercentage = request.DiscountPercentage;
                getPromotion.PromotionName = request.PromotionName;
                getPromotion.Quantity = request.Quantity;

                _repositoryManager.PromotionRepository.Update(getPromotion);
                await _repositoryManager.SaveAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                throw new Exception("DB error");

            }
        }

        //public async Task<bool> ValidatePromotion(string discountCode)
        //{
        //    var promotion = await _repositoryManager.PromotionRepository.GetPromotionByDiscountCode(discountCode);
        //    if(promotion == null)
        //    {
        //        throw new Exception("Mã giảm giá không tìm thấy.");
        //    }
        //    // kiem tra voucher xem con su dung duoc khong
        //    if(promotion.Status == false)
        //    {
        //        throw new Exception("Mã giảm giá đã hết hạn.");
        //    }
        //    if(promotion.EndDate < DateTime.Now)
        //    {
        //        throw new Exception("Mã giảm giá đã hết hạn.");
        //    }
        //    if(promotion.Stock <= 0)
        //    {
        //        throw new Exception("Mã giảm giá không có sẵn.");
        //    }
        //    return true;
        //}       
    }
}
