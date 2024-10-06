namespace PureFood.Core.Models.content.Requests
{
    public class CreateOrderItemRequest
    {
        public Guid ProductId { get; set; }
       
        public int Quantity { get; set; }
        
    }
}
