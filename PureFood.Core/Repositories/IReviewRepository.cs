﻿using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IReviewRepository : IRepositoryBase<Review, Guid>
    {
        Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit);

        Task<IEnumerable<Review>> GetReviewByProductId(Guid productId);

        Task<IEnumerable<Review>> GetReviewByUserId(Guid userId);   
      //  Task<IEnumerable<Review>> GetReviewByUserId(Guid userId);

    }
}
