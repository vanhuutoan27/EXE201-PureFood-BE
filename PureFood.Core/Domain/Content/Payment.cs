using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureFood.Core.Domain.Content
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid? OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
    }
}