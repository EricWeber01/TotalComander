﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalComander
{
    class Calculator : ICalc
    {
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
