using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Domain.Content
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
    }
}