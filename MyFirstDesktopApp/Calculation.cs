﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDesktopApp
{
    public class Calculation
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Result { get => Number1 + Number2; }
    }
}
