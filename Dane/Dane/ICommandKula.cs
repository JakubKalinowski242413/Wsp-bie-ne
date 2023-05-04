﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dane
{
    public interface ICommandKula
    {
        int XPosition { get; set; }
        int YPosition { get; set; }
        int Radius { get; set; }
        int Mass { get; }
        int XSpeed { get; set; }
        int YSpeed { get; set; }
        int[] BaseColor { get; set; }
        int[] CurrentColor { get; set; }
    }
}
