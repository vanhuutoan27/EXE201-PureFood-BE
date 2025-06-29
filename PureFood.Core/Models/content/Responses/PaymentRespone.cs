using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class PaymentRespone
    {
        public Guid PaymentId { get; set; }
        [JsonPropertyName("order")]
        public Guid? OrderId { get; set; }
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}