using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PureFood.Core.Models.Requests
{
    public class CreateCartRequest
    {
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        public ICollection<CreateCartItemsRequest> CartItems {get ; set ;}
    }
    public class CreateCartItemsRequest
    {
        
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}