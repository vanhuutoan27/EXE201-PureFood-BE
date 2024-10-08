using System.Text.Json.Serialization;

namespace PureFood.Core.Models.Requests
{
    public class CreatePaymentRequest
    {
        [JsonPropertyName("order")]
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
    }
}