/*Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10
итераций) увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток.
Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в
результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в
произвольном порядке.*/

int counter = 0;
object locker = new object();

void Method()
{
    lock (locker)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Counter - {++counter} --- Thread - {Thread.CurrentThread.GetHashCode()}");
        }

    }
}

Thread[] threads = new Thread[3];
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(Method);
    threads[i].Start();
}


