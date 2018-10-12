using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibraryCore
{
    public class ConnectionResponse
    {
        public string type { get; set; }
        public string requestId { get; set; }
        public string timestamp { get; set; }
        public string name { get; set; }
        public ConnectionResponse_Status status { get; set; }
        public ConnectionResponse_Payload payload { get; set; }
        public string token { get; set; }
    }
}
