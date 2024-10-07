using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureFood.Core.Domain.Content
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } //
        public Guid UserId { get; set; } //response user
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Commune { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? PromotionId { get; set; }

        [ForeignKey(nameof(PromotionId))]
        public Promotion Promotion { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
