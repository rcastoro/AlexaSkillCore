﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RuckusAlexaLibrary.ISP
{
    public class InSkillProducts
    {
        public List<InSkillProduct> inSkillProducts { get; set; }
        public bool isTruncated { get; set; }
        public string nextToken { get; set; }
    }
}
