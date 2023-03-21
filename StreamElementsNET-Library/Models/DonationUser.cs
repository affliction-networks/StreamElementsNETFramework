using Newtonsoft.Json;

namespace StreamElements.Net.Models
{

    public class DonationUser
    {

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("geo")]
        public string geo { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }
    }
}