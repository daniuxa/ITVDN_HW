using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16_Essential_
{
    internal class House : ICloneable
    {
        public string? Adress { get; set; }
        public int Price { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public object NonDeepClone()
        {
            return this;
        }
        public override string ToString()
        {
            return Adress + " " + Price;
        }
    }
}
