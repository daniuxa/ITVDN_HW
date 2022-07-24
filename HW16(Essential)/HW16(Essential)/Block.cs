using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16_Essential_
{
    internal class Block
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public override bool Equals(object? obj)
        {
            Block? block = obj as Block;
            if (obj == null || block == null)
            {
                return false;
            }
            else if (block.A == this.A && block.B == this.B && block.C == this.C && block.D == this.D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return A ^ B ^ C ^ D;
        }

        public override string ToString()
        {
            return A + " " + B + " " + C + " " + D;
        }
    }
}
