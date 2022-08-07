using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Professional_
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class AccessLevelAttribute : Attribute
    {
        public AccessLevel accessLevel { get; }

        public AccessLevelAttribute(AccessLevel accessLevel)
        {
            this.accessLevel = accessLevel;
        }
    }
}
