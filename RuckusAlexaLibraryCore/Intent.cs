using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibraryCore
{
    /// <summary>
    /// The intent object that represents what the user wants.
    /// </summary>
    public class Intent
    {
        /// <summary>
        /// A string representing the name of the intent.
        /// </summary>
        public string name { get; set; }

        public string confirmationStatus { get; set; }

        /// <summary>
        /// A map of key-value pairs that further describes what
        /// the user meant based on a predefined intent schema.
        /// </summary>
        public Dictionary<string, Slot> slots { get; set; }

        public void ResetSlots()
        {
            foreach(KeyValuePair<string, Slot> slot in slots)
            {
                slot.Value.Value = null;
                slot.Value.Resolutions = null;
            }
        }

        public bool HasNullSlots()
        {
            foreach (KeyValuePair<string, Slot> slot in slots)
            {
                if (slot.Value.Value == null && slot.Value.Name != "priceatpurchasecents" && slot.Value.Name != "qtyowned")
                    return true;
            }
            return false;
        }
    }
}
