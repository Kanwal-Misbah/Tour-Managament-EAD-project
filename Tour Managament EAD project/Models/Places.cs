using System.Text.Json.Serialization;
using System.Text.Json;

namespace Tour_Managament_EAD_project.Models
{
    public class Places
    {
        [JsonPropertyName("p_name")]
        public string place_name { get; set; }
        [JsonPropertyName("c_name")]
        public string city_name { get; set; }
        [JsonPropertyName("desc")]
        public string place_description { get; set; }
        [JsonPropertyName("image")]
        public string place_Image { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Places>(this);
        }
    }
}
