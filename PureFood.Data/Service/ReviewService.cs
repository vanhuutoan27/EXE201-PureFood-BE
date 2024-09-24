using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;
using PureFood.Data.Repositories;
using System.Net.WebSockets;

namespace PureFood.Data.Service
{
    public class ReviewService : IReviewService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ReviewService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> ChangeFlagAsync( Guid reviewId)
        {

            var review = await _repositoryManager.ReviewRepository.GetByIdAsync(reviewId);
            if (review == null)
            {
                return false;
            }
            var check = review.flag;
            if (check == true)
            {
                review.flag = false;
            }
            else
            {
                review.flag = true;
            }

            _repositoryManager.ReviewRepository.Update(review);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> createReview(CreateReviewRequest review)
        {
            var getProduct = await _repositoryManager.ReviewRepository.GetReviewByProductId(review.ProductId);
            if (getProduct == null) {
                throw new Exception("Not found product");
            }
            var getUser = await _repositoryManager.ReviewRepository.GetReviewByUserId(review.UserId);
            if (getUser == null) {
                throw new Exception("Not Found User");
            }
            try { 
            var newReview = new Review
            {
                ProductId = review.ProductId,
                UserId = review.UserId,
                Comment = review.Comment,
                CreatedAt = DateTime.UtcNow,
                Rating = review.Rating,
                ReviewId = Guid.NewGuid(),
                flag = false,
            };
            _repositoryManager.ReviewRepository.Add(newReview);
            await _repositoryManager.SaveAsync();
              }catch (DbUpdateException) {
                throw new Exception("DB Error");

            }
            return true;



        }

        public async Task<bool> deleteReview(Guid id)
        {
            try {
            var getReview = await _repositoryManager.ReviewRepository.GetByIdAsync(id);
            if (getReview == null)
            {
                throw new Exception("Not Found");
            }
             _repositoryManager.ReviewRepository.Remove(getReview);
                _repositoryManager.SaveAsync();
            }
            catch (DbUpdateException) {
                throw new Exception("DB error");
            }
            return true;
        }

        public async Task<PageResult<ReviewReponse>> getAll(int page, int limit)
        {
            var reviewCategory = await _repositoryManager.ReviewRepository.GetAllReviewAsync(page, limit);
            var totalItems = reviewCategory.Count();

            var reviewReponse = _mapper.Map<IEnumerable< ReviewReponse>>(reviewCategory);
            return new PageResult<ReviewReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = reviewReponse
            };
        }

        public async Task<ReviewReponse> getReviewById(Guid reviewid)
        {
            var reviewRepository = await _repositoryManager.ReviewRepository.GetByIdAsync(reviewid);
            var reviewReponse = _mapper.Map<ReviewReponse>(reviewRepository);
            return reviewReponse;
        }

        public async Task<IEnumerable<ReviewReponse>> getReviewByProductId(Guid productid)
        {
            var reviewRepository = await _repositoryManager.ReviewRepository.GetReviewByProductId(productid);
            var reviewReponse = _mapper.Map<IEnumerable< ReviewReponse>>(reviewRepository);
            return reviewReponse;
        }

        public async Task<IEnumerable<ReviewReponse>> getReviewByUserId(Guid userId)
        {
            var reviewRepository = await _repositoryManager.ReviewRepository.GetReviewByUserId(userId);
            var reviewReponse = _mapper.Map<IEnumerable< ReviewReponse>>(reviewRepository);
            return reviewReponse;
        }

        public async Task<bool> updateReview(Guid id, CreateReviewRequest review)
        {
            var getReview = await _repositoryManager.ReviewRepository.GetByIdAsync(id);

            if (review == null) {
                throw new Exception("Not Found");
            }
            try { 
            getReview.Comment = review.Comment;
            getReview.Rating = review.Rating;
                
                _repositoryManager.ReviewRepository.Update(getReview);
                await _repositoryManager.SaveAsync();
                return true;
            } catch (DbUpdateException) {
                throw new Exception("DB error");
            
            }



        }
    }
}
