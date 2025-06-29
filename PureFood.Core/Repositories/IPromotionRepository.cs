﻿using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Repositories
{
    public interface IPromotionRepository : IRepositoryBase<Promotion, Guid>
    {
        Task<IEnumerable<Promotion>> GetAllPromotionAsync(int page, int limit);
        Task<Promotion> GetPromotionByDiscountCode(string discountCode);
        IEnumerable<Promotion> GetExpiredPromotions();
    }
}
