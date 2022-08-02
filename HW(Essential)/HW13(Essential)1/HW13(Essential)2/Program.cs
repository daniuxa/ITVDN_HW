using HW13_Essential_2;

Console.SetWindowSize(50, 30);
for (int i = 0; i < 50; i++)
{
    Thread thread = new Thread(() => { new Chain(i).Move(); });
    thread.Start();
    Random random = new Random();
    Thread.Sleep(random.Next(1000, 10000));
}
