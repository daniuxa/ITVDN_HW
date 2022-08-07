using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Professional_
{
    internal class Tempreture
    {
        public double CurrentTempreture { get; set; }
        public Tempreture(double temp)
        {
            CurrentTempreture = temp;
        }

        public double GetTemp()
        {
            return CurrentTempreture;
        }
    }
}
