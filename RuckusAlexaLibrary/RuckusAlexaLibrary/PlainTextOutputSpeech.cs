using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RuckusAlexaLibrary;
using System.ComponentModel.DataAnnotations;

namespace RuckusAlexaLibrary
{
    public class PlainTextOutputSpeech : IOutputSpeech
    {
        public PlainTextOutputSpeech() { }

        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public string Text { get; set; }
        [JsonProperty("ssml", NullValueHandling = NullValueHandling.Ignore)]
        public string SSML { get; set; }
    }
}
