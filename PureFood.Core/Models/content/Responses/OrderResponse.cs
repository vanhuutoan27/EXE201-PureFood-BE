using System.Text.Json.Serialization;

namespace PureFood.Core.Models.content.Responses
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; } //
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
        //public decimal totalAmount { get; set; }
        [JsonPropertyName("voucher")]
        public string? DiscountCode { get; set; }
        public string OrderStatus { get; set; }
        public List<OrderItemResponse> orderSummary { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
