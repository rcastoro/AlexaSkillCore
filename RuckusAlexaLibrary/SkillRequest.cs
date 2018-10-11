using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibrary
{
    /// <summary>
    /// The request object container sent to the Alexa service.
    /// </summary>
    public class SkillRequest
    {
        /// <summary>
        /// Initializes a new SkillRequest object
        /// </summary>
        public SkillRequest() { }

        /// <summary>
        /// Initializes a new SkillRequest object with parameters
        /// </summary>
        /// <param name="version"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="context"></param>
        public SkillRequest(string version, Session session, RequestBundle request, Context context)
        {
            Version = version;
            Session = session;
            Request = request;
            Context = context;
        }

        /// <summary>
        /// The version specifier for the request with the value defined as: "1.0"
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The session object provides additional context associated with the request.
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Contains the request object, interfaces for Launch Request, Intent Request, and Session Ended Request, 
        /// </summary>
        public RequestBundle Request { get; set; }

        /// <summary>
        /// The context object provides your skill with information about the current state of the Alexa service 
        /// and device at the time the request is sent to your service. This is included on all requests. For 
        /// requests sent in the context of a session (LaunchRequest and IntentRequest), the context object 
        /// duplicates the user and application information that is also available in the session.
        /// </summary>
        public Context Context { get; set; }

        /// <summary>
        /// Returns type of request
        /// </summary>
        /// <returns>Type of ILaunchRequest, IIntentRequest, or ISessionEndedRequest</returns>
        public Type GetRequestType()
        {
            return Request.GetRequestType();
        }

    }
}
