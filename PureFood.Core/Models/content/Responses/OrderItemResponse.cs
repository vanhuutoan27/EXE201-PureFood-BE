
namespace PureFood.Core.Models.content.Responses
{
    public class OrderItemResponse
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public static implicit operator List<object>(OrderItemResponse v)
        {
            throw new NotImplementedException();
        }
    }
}
