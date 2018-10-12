using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace RuckusAlexaLibraryCore
{
    public class ResolutionsPerAuthority
    {
        public ResolutionsPerAuthority() { }

        public string authority { get; set; }
        public Status status { get; set; }
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<Value> values { get; set; }
    }
}
