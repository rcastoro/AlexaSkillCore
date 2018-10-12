using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibraryCore
{
    public class CanFulfillIntent
    {
        public string canFulfill { get; set; }
        public List<CanFulfillSlot> slots { get; set; }
    }
}
