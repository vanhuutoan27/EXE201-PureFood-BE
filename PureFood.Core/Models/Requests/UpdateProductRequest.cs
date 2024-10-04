using System.Text.Json.Serialization;

namespace PureFood.Core.Models.Requests
{
    public class UpdateProductRequest
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Weight { get; set; }
        public string Unit { get; set; }
        public string Origin { get; set; }
        public bool Organic { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        [JsonPropertyName("category")]
        public Guid CategoryId { get; set; }
        [JsonPropertyName("supplier")]
        public Guid SupplierId { get; set; }
    }
}
