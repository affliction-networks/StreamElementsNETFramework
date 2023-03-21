using Newtonsoft.Json;

namespace StreamElements.Net.Models
{

    public class Tips
    {

        [JsonProperty("docs")]
        public TipDocs docs { get; set; }

        [JsonProperty("subscriberMultiplier")]
        public int SubscriberMultiplier { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}