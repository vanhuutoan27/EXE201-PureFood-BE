using System.ComponentModel.DataAnnotations;

namespace PureFood.Core.Domain.Content
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
