using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.Core.Services
{
    public interface IReviewService
    {
        Task<PageResult<ReviewReponse>> getAll(int page, int limit);

        Task<ReviewReponse> getReviewById(Guid reviewid);

        Task<IEnumerable< ReviewReponse>> getReviewByUserId(Guid userId);
        Task<IEnumerable< ReviewReponse>> getReviewById(int reviewid);

        Task<bool> createReview(CreateReviewRequest review);  

        Task<bool> updateReview(Guid id , CreateReviewRequest review);

        Task <bool> deleteReview (Guid id); 


    }
}
