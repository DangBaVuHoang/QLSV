﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    class CBBItem
    {
        public int Value { get; set; }
        public string text { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
