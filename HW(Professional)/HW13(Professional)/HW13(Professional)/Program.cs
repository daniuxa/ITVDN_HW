﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13_Professional_
{
    /*Создайте приложение WindowsForms. На главной форме приложения разместите 3 кнопки с
    названиями: IsComplete, End, Callback. Организуйте обработчики нажатия на кнопки таким
    образом, чтобы они инициировали асинхронное выполнение некоторого метода (метод
    определите сами, можно воспользоваться чем-то вроде Add или более абстрактного Compute).
    Для каждой из кнопок завершение асинхронного метода должно отслеживаться
    соответствующим образом:
    - IsComplete – с использованием значения свойства IsComplete
    - End – просто применяя EndInvoke
    - Callback – с использованием callback метода*/
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
