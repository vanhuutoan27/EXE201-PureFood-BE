using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Models.Requests
{
    public class CreatePaymentRequest
    {
        [JsonPropertyName("order")]
        public Guid? OrderId { get; set; }
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}