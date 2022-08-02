using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class MyCollection 
    {
        private List<object> list = new List<object>();


        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine((item as Person)!.Id);
            }
        }
        public int Add(object obj)
        {
            //Person? pers = obj as Person;
            if (obj is not Person)
            {
                return -1;
            }

            if (list.Contains(obj))
            {
                throw new ArgumentException("Incorrect input");
            }
           
            if (obj is Pensioner)
            {
                int i = 0;
                bool Pasted = false;
                for (; i < list.Count; i++)
                {
                    if (list[i] is not Pensioner)
                    {
                        list.Insert(i, obj);
                        Pasted = true;
                        break;
                    }
                }
                if (!Pasted)
                {
                    list.Add(obj);
                    return list.Count - 1;
                }
                return i;

            }
            else
            {
                list.Add(obj);
                return list.Count - 1;
            }
        }

        public void Delete(int index)
        {
            list.RemoveAt(index);
        }
        public void Delete(object obj)
        {
            list.Remove(obj);
        }
    }
}
