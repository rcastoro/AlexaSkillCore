using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibraryCore
{
    /// <summary>
    /// The response.
    /// </summary>
    /// <remarks>
    /// This is a remark.
    /// </remarks>
    public class Response
    {

        public Response() { }

        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public PlainTextOutputSpeech OutputSpeech { get; set; }
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public ICard Card { get; set; }
        [JsonProperty("reprompt", NullValueHandling = NullValueHandling.Ignore)]
        public Reprompt Reprompt { get; set; }
        [JsonProperty("directives", NullValueHandling = NullValueHandling.Ignore)]
        public List<IDirective> Directives { get; set; } = new List<IDirective>();
        [JsonProperty("shouldEndSession", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldEndSession { get; set; }

    }
}
