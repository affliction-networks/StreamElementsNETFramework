using System;

namespace StreamElements.Net.Models.Results
{
    public class TipResult : Loyalty, IStreamElementsResult
    {
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string User { get; set; }
        public string Username { get; set; }
    }
}