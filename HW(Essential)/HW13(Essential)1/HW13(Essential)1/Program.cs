RecursionMethode();

void RecursionMethode()
{
    Thread thread = new Thread(RecursionMethode);
    thread.Start();
    Console.WriteLine(thread.Name);
    Thread.Sleep(2000);
}