using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    public class Status
    {
        public string code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string message { get; set; }
    }
}
