using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Slot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Newtonsoft.Json.Bson.BsonWriter"/> class.
        /// </summary>
        public Slot()
        {

        }

        /// <summary>
        /// A string that represents the name of the slot.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("resolutions", NullValueHandling = NullValueHandling.Ignore)]
        public Resolutions Resolutions { get; set; }

        public string confirmationStatus { get; set; } = "NONE";
    }
}
