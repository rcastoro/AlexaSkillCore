using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RuckusAlexaLibraryCore
{
    public class CanFulfill
    {
        public string version { get; set; }
        public CanFulfillResponse response { get; set; }
    }
}
