using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RuckusAlexaLibrary
{
    public interface IResponse
    {
        [Required]
        string Type { get; }
    }
}
