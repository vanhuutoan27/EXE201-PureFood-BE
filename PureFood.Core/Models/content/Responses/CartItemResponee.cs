using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class CartItemResponee
    {

        public Guid CartItemId { get; set; }
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        public string? Slug { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string? Unit { get; set; }
        public string? Origin { get; set; }
        public bool? Organic { get; set; }
        public List<string> Images { get; set; }
        public bool? Status { get; set; }
    }
}