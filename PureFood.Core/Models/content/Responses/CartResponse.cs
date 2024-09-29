using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class CartResponse
    {

        public Guid CartId { get; set; }
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        public ICollection<CartItemRespone> CartItems { get; set; }

    }
    public class CartItemRespone
    {

        public Guid CartItemId { get; set; }
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Weight { get; set; }
        public string? Unit { get; set; }
        public string? Origin { get; set; }
        public bool? Status { get; set; }
        public bool? Organic { get; set; }
    }
}