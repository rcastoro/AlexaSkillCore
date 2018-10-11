using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RuckusAlexaLibrary
{
    public class SimpleCard : ICard
    {
        public string type
        {
            get { return "Simple"; }
        }

        public virtual string title
        {
            get;
            set;
        }

        public virtual string content
        {
            get;
            set;
        }

        public string Type
        {
            get { return "Simple"; }
        }
    }
}
