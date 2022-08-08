using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Professional_
{
    [Serializable]
    internal class MyClass
    {
        private int field1;
        public int field2 { get; set; }

        public MyClass(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }

        public void MyMethod()
        {
            Console.WriteLine(field1 + " " + field2);
        }
    }
}
