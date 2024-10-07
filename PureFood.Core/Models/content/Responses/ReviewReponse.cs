using System.Text.Json.Serialization;

namespace PureFood.Core.Models.content.Responses
{
    public class ReviewReponse
    {
        public Guid ReviewId { get; set; }
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        [JsonPropertyName("product")]
        public Guid ProductId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

    }
}
