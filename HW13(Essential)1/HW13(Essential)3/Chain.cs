using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_Essential_3
{
    internal class Chain
    {
        static object locker = new object();
        static List<Point> PointInUse = new List<Point>();
        private int Size;
        public int PosX { get; set; }
        private int PosY;
        private char[] Body;

        private int Size2;
        private int PosY2;
        private char[] Body2;

        private int LPoint = 0;
        public Chain(int PosX)
        {
            Random x = new Random();
            Size = x.Next(3, 10);
            Size2 = x.Next(3, 10);
            Body = new char[Size];
            Body2 = new char[Size2];    
            this.PosX = PosX;
            PosY = 0;
            PosY2 = 0;
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
                            LPoint = PosY - i;
                        }
                        
                    }
                }
                PosY += 1;
                if (PosY == 30)
                {
                    PosY = 0;
                }
                Thread.Sleep(1000);
                ClearRow(PosX);
                Thread.Sleep(20);
            }
        }

        public void Move2()
        {
            
            while (true)
            {
                if (LPoint != PosY2)
                {
                    for (int i = 0; i < Size2; i++)
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
                            Body2[i] = Convert.ToChar(x.Next(65, 91));
                            if (PosY2 - i >= 0)
                            {
                                Console.SetCursorPosition(PosX, PosY2 - i);
                                Console.Write(Body2[i]);
                            }
                        }
                    }
                    PosY2 += 1;
                    if (PosY2 == 30)
                    {
                        PosY2 = 0;
                    }
                    Thread.Sleep(750);
                    ClearRow(PosX);
                    Thread.Sleep(20);
                }
                else
                {
                    Thread.Sleep(7000);
                }    
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
