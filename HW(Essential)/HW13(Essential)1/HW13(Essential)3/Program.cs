using HW13_Essential_3;

Console.SetWindowSize(50, 30);
for (int i = 0; i < 2; i++)
{
    Chain chain = new Chain(i);
    Thread thread = new Thread(() => { chain.Move(); });
    thread.Start();
    Thread thread2 = new Thread(() => { chain.Move2(); });
    thread2.Start();
    Random random = new Random();
    Thread.Sleep(random.Next(1000, 10000));
}


/*Thread thread = new Thread(() => { new Chain(0).Move(); });
thread.Start();
Thread.Sleep(10000);
Thread thread1 = new Thread(() => { new Chain(0).Move(); });
thread1.Start();*/
