using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RuckusAlexaLibrary
{
    public class Session
    {
        public bool New { get; set; }
        public string SessionId { get; set; }
        public Dictionary<string, object> Attributes { get; set; }
        public Application Application { get; set; }
        public User User { get; set; }
    }
}
