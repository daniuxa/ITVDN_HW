using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_Essential_Collections2
{
    static class Extensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] ts = new T[list.Count()];
            int i = 0;
            foreach (T t in list)
            {
                ts[i++] = t;
            }
            return ts;
        }
    }
}
