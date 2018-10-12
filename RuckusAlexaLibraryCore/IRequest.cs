using System;

namespace RuckusAlexaLibraryCore
{
    public interface IRequest
    {
        string Type { get; set; }
        string RequestId { get; set; }
        DateTime Timestamp { get; set; }
    }
}
