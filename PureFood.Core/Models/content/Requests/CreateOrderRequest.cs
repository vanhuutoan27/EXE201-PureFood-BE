using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PureFood.Core.Models.content.Requests
{
    public class CreateOrderRequest
    {
        [JsonPropertyName("user")]
        public Guid UserId { get; set; } //response user
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Commune { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string PaymentMethod { get; set; }
        public decimal totalAmount { get; set; }
        [JsonPropertyName("voucher")]
        [DefaultValue(null)] //"string"
        public string? DiscountCode { get; set; } = null;
        // public string OrderStatus { get; set; }
        public List<CreateOrderItemRequest> orderSummary { get; set; }
    }
}
