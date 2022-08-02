using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Essential_Clock
{
    internal class Model
    {
        private TimeSpan Time { get; set; } = TimeSpan.Zero;
        
        public TimeSpan Timer(bool Reset = false)
        {
            if (Reset == false)
            {
                Time += new TimeSpan(0, 0, 0, 1);
            }          
            else
            {
                Time = TimeSpan.Zero;
            }
            return Time;            
        }
    }
}
