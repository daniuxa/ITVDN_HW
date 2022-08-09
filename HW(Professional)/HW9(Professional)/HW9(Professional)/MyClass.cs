using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Professional_
{
    internal class MyClass : IDisposable
    {
        int[] vs = new int[100000000];
        private bool disposed = false;

        public void Dispose()
        {
            Console.WriteLine(GC.GetTotalMemory(false)); 
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) 
                return;
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
            }
            // освобождаем неуправляемые объекты
            disposed = true;
        }
        ~MyClass()
        {
            Dispose(false);
        }
    }
}
