using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class PromotionReponse
    {

        public Guid PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string? Description { get; set; }
        public string DiscountCode { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Stock { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedBy { get; set; }
        public DateTime? UpdatedBy { get; set; }

    }
}
