using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Essential_Calculator
{
    internal class Model
    {
        public double Calculate(string NumStr)
        {
            double result = 0;
            string[] ParseChars = NumStr.Split('+', '-', '*', '/');
            if (ParseChars.Length == 2)
            {
                if (NumStr.Contains("+"))
                {
                    result = double.Parse(ParseChars[0]) + double.Parse(ParseChars[1]);
                }
                else if (NumStr.Contains("-"))
                {
                    result = double.Parse(ParseChars[0]) - double.Parse(ParseChars[1]);
                }
                else if (NumStr.Contains("*"))
                {
                    result = double.Parse(ParseChars[0]) * double.Parse(ParseChars[1]);
                }
                else if (NumStr.Contains("/"))
                {
                    result = double.Parse(ParseChars[0]) / double.Parse(ParseChars[1]);
                }
            }
            else
            {
                throw new Exception("Must be only 2 operands sepparated by (+, -, *, /)");
            }
            return result;
        }
    }
}
