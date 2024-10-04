using System.Text.Json.Serialization;

namespace PureFood.Core.Models.Requests
{
    public class CreateProductRequest
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Weight { get; set; }
        public string Unit { get; set; }
        public string Origin { get; set; }
        public string FoodName { get; set; }
        public bool Organic { get; set; }
        [JsonPropertyName("category")]
        public string CategoryName { get; set; }
        [JsonPropertyName("supplier")]
        public string SupplierName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<string>? Images { get; set; } = new List<string>();
    }
}
