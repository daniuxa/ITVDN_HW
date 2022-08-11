/*Создайте Semaphore, осуществляющий контроль доступа к ресурсу из нескольких потоков.
Организуйте упорядоченный вывод информации о получении доступа в специальный *.log
файл.*/


Semaphore semaphore = new Semaphore(2, 4);
Thread[] threads = new Thread[10];
object obj = new object();
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(() => { MakeConnection(semaphore); });
    threads[i].Start();
}

void MakeConnection(Semaphore sem)
{
    sem.WaitOne();
    try
    {
        //lock (obj)
        {
            using (FileStream fileStream = new FileStream("Log.log", FileMode.Open, FileAccess.Read))
            {
                Console.WriteLine($"Thread - {Thread.CurrentThread.GetHashCode()} made a connection");
                Thread.Sleep(1500);
            }
            Console.WriteLine($"Thread - {Thread.CurrentThread.GetHashCode()} close a connection");
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }    
    sem.Release();
}
