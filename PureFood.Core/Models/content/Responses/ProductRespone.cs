
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class ProductRespone
    {
        public Guid ProductId { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
              //  public string SupplierName { get; set; }

        public string ProductName { get; set; }
        public string FoodName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Weight { get; set; }
        public string Unit { get; set; }
        public string Origin { get; set; }
        public bool Organic { get; set; }
        public ICollection<ImageResponse> Images { get; set; }
        public bool Status { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
    public class ImageResponse
{
    public string Url { get; set; }
}
}
