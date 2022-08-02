using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_Essential_2
{
    internal class Chain
    {
        static object locker = new object();
        private int Size;
        public int PosX { get; set; }
        private int PosY;
        private char[] Body;
        public Chain(int PosX)
        {
            Random x = new Random();
            Size = x.Next(3, 10);
            Body = new char[Size];
            this.PosX = PosX;
            PosY = 0;
        }
        public void Move()
        {
            Random random = new Random();
            
            while (true)
            {
                
                for (int i = 0; i < Size; i++)
                {
                    lock (locker)
                    {
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Random x = new Random();
                        Body[i] = Convert.ToChar(x.Next(65, 91));
                        if (PosY - i >= 0)
                        {
                            Console.SetCursorPosition(PosX, PosY - i);
                            Console.Write(Body[i]);
                        }
                    }    
                }
                PosY += 1;
                if (PosY == 30)
                {
                    PosY = 0;
                }
                Thread.Sleep(750);
                ClearRow(PosX);
                Thread.Sleep(20);
            }   
        }
        private void ClearRow(int PosX)
        {
            for (int i = 0; i < 30; i++)
            {
                lock (locker)
                {
                    Console.SetCursorPosition(PosX, i);
                    Console.Write(" ");
                }               
            }
             
        }
    }
}
