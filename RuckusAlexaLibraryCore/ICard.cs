using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RuckusAlexaLibraryCore
{
    public interface ICard : IResponse
    {
        string type
        {
            get;
        }
    }
}
