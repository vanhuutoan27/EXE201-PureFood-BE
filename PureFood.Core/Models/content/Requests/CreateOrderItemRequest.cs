using System.Text.Json.Serialization;

namespace PureFood.Core.Models.content.Requests
{
    public class CreateOrderItemRequest
    {
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

    }
}
