using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Requests
{
    public class CreatePromotionRequest
    {

        public Guid PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string? Description { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
    }
}
