using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibraryCore
{
    public class DirectivePurchaseOutput : IDirective
    {
        public DirectivePurchaseOutput()
        {

        }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public Payload payload { get; set; } = new Payload();

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string token { get; set; }
    }
}
