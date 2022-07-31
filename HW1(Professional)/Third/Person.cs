using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    abstract internal class Person
    {
        static int i = 0;
        public int Id { get; set; }
        public Person()
        {
            Id = i++;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType() != this.GetType())
            {
                return false;
            }
            if (this.Id == (obj as Person)!.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
