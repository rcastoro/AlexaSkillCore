using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibrary.ISP
{
    public class InSkillProduct
    {

        [JsonProperty("productId", NullValueHandling = NullValueHandling.Ignore)]
        public string productId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string summary { get; set; }

        [JsonProperty("entitled", NullValueHandling = NullValueHandling.Ignore)]
        public string entitled { get; set; }

        [JsonProperty("purchasable", NullValueHandling = NullValueHandling.Ignore)]
        public string purchasable { get; set; }
    }
}
