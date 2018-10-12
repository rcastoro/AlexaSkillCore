using System;
using System.Collections.Generic;
using System.Text;
using RuckusAlexaLibraryCore.ISP;
using Newtonsoft.Json;

namespace RuckusAlexaLibraryCore
{
    public class Payload
    {

        public InSkillProduct InSkillProduct { get; set; }

        [JsonProperty("upsellMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string upsellMessage {get;set;}
    }
}
