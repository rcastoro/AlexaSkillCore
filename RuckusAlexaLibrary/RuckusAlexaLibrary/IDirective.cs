using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    public interface IDirective
    {

        [JsonProperty("type")]
        string type { get; set; }

    }
}
