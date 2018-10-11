using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibrary
{
    public class System
    {
        public Device device { get; set; }
        public Application application { get; set; }
        public User2 user { get; set; }
        public string apiEndpoint { get; set; }
        public string apiAccessToken { get; set; }
    }
}
