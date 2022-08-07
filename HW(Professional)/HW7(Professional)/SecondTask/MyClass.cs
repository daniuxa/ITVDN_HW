using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class MyClass
    {
        [Obsolete("Warning", false)]
        public void MyMethodWarning()
        {

        }

        [Obsolete("Error", true)]
        public void MyMethodError()
        {

        }
    }
}
