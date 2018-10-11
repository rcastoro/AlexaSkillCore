using System;
using System.Collections.Generic;
using System.Text;
using RuckusAlexaLibrary.ISP;
using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    public class Payload
    {

        public InSkillProduct InSkillProduct { get; set; }

        [JsonProperty("upsellMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string upsellMessage {get;set;}
    }
}
