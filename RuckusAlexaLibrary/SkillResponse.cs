using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RuckusAlexaLibrary
{
    /// <summary>
    /// The response object container returned from the Alexa service.
    /// </summary>
    public class SkillResponse
    {
        /// <summary>
        /// Initializes a new SkillResponse object
        /// </summary>
        public SkillResponse() { }

        /// <summary>
        /// Initializes a new SkillResponse object with parameters
        /// </summary>
        /// <param name="version"></param>
        /// <param name="sessionAttributes"></param>
        /// <param name="response"></param>
        public SkillResponse(string version, Dictionary<string, object> sessionAttributes, Response response)
        {
            Version = version;
            SessionAttributes = sessionAttributes;
            Response = response;
        }


        /// <summary>
        /// The version specifier for the response with the value to be defined as: "1.0"
        /// </summary>
        [JsonProperty("version")]
        [Required]
        public string Version { get; set; }

        /// <summary>
        /// A map of key-value pairs to persist in the session. The key is a string that represents the name of the attribute.Type: string. 
        /// The value is an object that represents the value of the attribute. Type: object. Session attributes are ignored if included 
        /// in a response to an AudioPlayer or PlaybackController request. 
        /// </summary>
        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }

        /// <summary>
        /// A response object that defines what to render to the user and whether to end the current session.
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public Response Response { get; set; }

    }
}
