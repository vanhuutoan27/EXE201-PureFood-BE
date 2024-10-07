using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.Core.Services
{
    public interface IPromotionService
    {

        Task<PageResult<PromotionReponse>> getAll(int page, int limit);
        Task<PromotionReponse> getPromotionById(Guid promotionId);
        Task<bool> ChangeStatus(Guid promotionId);
        Task<bool> createPromotion(CreatePromotionRequest request);
        Task<bool> updatePromotion(Guid id, UpdatePromotionRequest request);
        Task<bool> deletePromotion(Guid id);
        Task<bool> ChangeStatusPromotion(Guid id);
    }
}
