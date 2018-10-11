using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    /// <summary>
    /// The request bundle object that is sent to the Alexa service. Bundled to encapsulate request functionality.
    /// </summary>
    public class RequestBundle : IIntentRequest, IRequest, ILaunchRequest, ISessionEndedRequest
    {
        /// <summary>
        /// Initializes a new RequestBundle object
        /// </summary>
        public RequestBundle() { }

        /// <summary>
        /// /// Initializes a new RequestBundle object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestId"></param>
        /// <param name="timestamp"></param>
        /// <param name="intent"></param>
        /// <param name="reason"></param>
        /// <param name="dialogState"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="payload"></param>
        /// <param name="token"></param>
        /// <param name="confirmationStatus"></param>
        public RequestBundle(string type, string requestId, DateTime timestamp, Intent intent, string reason, string dialogState, string name, ConnectionResponse_Status status, ConnectionResponse_Payload payload, string token, string confirmationStatus)
        {
            Type = type;
            RequestId = requestId;
            Timestamp = timestamp;
            Intent = intent;
            Reason = reason;
            DialogState = dialogState;
            this.name = name;
            this.status = status;
            this.payload = payload;
            this.token = token;
            this.confirmationStatus = confirmationStatus;
        }

        /// <summary>
        /// Describes the request type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Represents a unique identifier for the specific request.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Provides the date and time when Alexa sent the request as an ISO 8601 formatted string. Used to verify the request when hosting your skill as a web service.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// An object that represents what the user wants.
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent Intent { get; set; }

        /// <summary>
        /// Describes why the session ended.
        /// </summary>
        /// <remarks>
        /// Only present in a SessionEndedRequest
        /// </remarks>
        /// <returns>
        /// USER_INITIATED
        /// ERROR
        /// EXCEEDED_MAX_REPROMPTS
        /// </returns>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Enumeration indicating the status of the multi-turn dialog. This property is included if the skill meets the requirements to use the Dialog directives Possible values"
        /// </summary>
        /// <returns>
        /// STARTED
        /// IN_PROGRESS
        /// COMPLETED        
        /// </returns>
        public string DialogState { get; set; }

        /// <summary>
        /// A string representing the name of the intent
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Provides details of the HTTP status	
        /// </summary>
        /// <remarks>
        /// Used for In Skill Purchasing, to resume the skill after the purchase flow.
        /// </remarks>
        public ConnectionResponse_Status status { get; set; }

        /// <summary>
        /// Contains details for the specified action. For a purchase request, this includes the InSkillProduct property with a product ID.
        /// </summary>
        public ConnectionResponse_Payload payload { get; set; }

        /// <summary>
        /// A token to identify this message exchange and store skill information. The token is not used by Alexa, but is returned in the resulting Connections.Response. 
        /// You provide this token in a format that makes sense for the skill.
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// Dialog status used to confirm fields that require confirmation as laid out in your Dialog Model
        /// </summary>
        public string confirmationStatus { get; set; }

        /// <summary>
        /// Returns type of request
        /// </summary>
        /// <returns>IntentRequest, LaunchRequest, SessionEndedRequest, Connections.Response</returns>
        public Type GetRequestType()
        {
            switch (Type)
            {
                case "IntentRequest":
                    return typeof(IIntentRequest);
                case "LaunchRequest":
                    return typeof(ILaunchRequest);
                case "SessionEndedRequest":
                    return typeof(ISessionEndedRequest);
                case "Connections.Response":
                    return typeof(ConnectionResponse);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Type), $"Unknown request type: {Type}.");
            }
        }
    }
}
