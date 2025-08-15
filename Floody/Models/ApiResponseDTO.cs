using System.Text.Json.Serialization;

namespace Floody.Models
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        [JsonPropertyName("foodid")]
        public string FoodId { get; set; }
    }
}
