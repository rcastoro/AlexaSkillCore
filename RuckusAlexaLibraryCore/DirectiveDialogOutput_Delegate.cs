using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RuckusAlexaLibraryCore;

namespace RuckusAlexaLibraryCore
{
    public class DirectiveDialogOutput_Delegate : IDirective
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent updatedIntent { get; set; }
    }
}
