using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal struct Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private int startWorkingYear;
        public int StartWorkingYear 
        {
            get
            { 
                return startWorkingYear;
            }
            set
            { 
                if (value > DateTime.Now.Year - 100 && value < DateTime.Now.Year - 18)
                {
                    startWorkingYear = value;
                }
                else
                {
                    throw new Exception("Incorrect year format");
                }
            } 
        }

    }
}
