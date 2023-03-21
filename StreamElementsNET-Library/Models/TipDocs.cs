using Newtonsoft.Json;

namespace StreamElements.Net.Models
{

    public class TipDocs
    {

        [JsonProperty("donation")]
        public Donation donation { get; set; }

        [JsonProperty("provider")]
        public string provider { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("transactionId")]
        public string transactionId { get; set; }

        [JsonProperty("approved")]
        public string approved { get; set; }
    }
}