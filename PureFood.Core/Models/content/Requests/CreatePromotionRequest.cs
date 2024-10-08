using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Requests
{
    public class CreatePromotionRequest
    {
        public string PromotionName { get; set; }
        public string? Description { get; set; }
        public string DiscountCode { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
