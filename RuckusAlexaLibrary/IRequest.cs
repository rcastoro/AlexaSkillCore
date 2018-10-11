using System;

namespace RuckusAlexaLibrary
{
    public interface IRequest
    {
        string Type { get; set; }
        string RequestId { get; set; }
        DateTime Timestamp { get; set; }
    }
}
