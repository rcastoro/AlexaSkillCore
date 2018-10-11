using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RuckusAlexaLibrary
{
    public interface ISessionEndedRequest : IRequest
    {
        string Reason { get; set; }
    }
}
