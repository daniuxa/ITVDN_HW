using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    static internal class ConvertorTemp
    {
        public static double Convert()
        {
            double result = 0;
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\saliv\source\repos\HW6(Professional)\SecondTaskDll\bin\Debug\net6.0\SecondTaskDll.dll");
            Type? type = assembly.GetType("SecondTaskDll.Tempreture");

            if (type == null)
            {
                throw new Exception();
            }

            object? instance = Activator.CreateInstance(type, 35);

            MethodInfo? method = type.GetMethod("GetTemp");

            if (instance != null && method != null)
            {
                result = (double)method.Invoke(instance, null);
            }
            else
            {
                throw new Exception();
            }

            return result;
        }
    }
}
