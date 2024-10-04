using PureFood.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PureFood.Core.Models.content.Requests
{
    public class CreateReviewRequest
    {
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
