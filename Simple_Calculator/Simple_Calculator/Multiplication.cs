﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Multiplication
    {
        public double multiplication(double first, double second)
        {
            double answer = first * second;

            Console.WriteLine("{0} * {1}", first, second);
            Console.WriteLine("=");
            Console.WriteLine(answer);
            return answer;
        }
    }
}
