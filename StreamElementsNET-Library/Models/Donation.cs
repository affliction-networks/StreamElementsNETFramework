
using Newtonsoft.Json;

namespace StreamElements.Net.Models
{

    public class Donation
    {

        [JsonProperty("user")]
        public DonationUser user { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("amount")]
        public double amount { get; set; }

        [JsonProperty("currency")]
        public string currency { get; set; }
    }
}