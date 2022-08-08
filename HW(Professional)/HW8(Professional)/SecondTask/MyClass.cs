using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SecondTask
{
    public class MyClass
    {
        private int field1;
        [XmlAttribute]
        public int field2 { get; set; }

        public MyClass(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }

        public MyClass()
        {
            this.field1 = 100;
            this.field2 = 100;
        }

        public void MyMethod()
        {
            Console.WriteLine(field1 + " " + field2);
        }
    }
}
