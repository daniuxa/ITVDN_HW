/*Создайте приложение, которое может быть запущено только в одном экземпляре (используя
именованный Mutex).*/
bool createdNew;
Mutex mutex = new Mutex(false, "MyMutex", out createdNew);

if (!createdNew)
{
    return;
}

mutex.WaitOne();
Console.WriteLine("Working....");
Thread.Sleep(50000);


mutex.ReleaseMutex();

