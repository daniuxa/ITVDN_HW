/*Переделайте дополнительное задание из урока 11 с использованием конструкции async
await.*/
/*Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10
итераций) увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток.
Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в
результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в
произвольном порядке.*/

int counter = 0;

Console.WriteLine(Thread.CurrentThread.GetHashCode());

await PrintCounterAsync();
await PrintCounterAsync();
await PrintCounterAsync();


void PrintCounter()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(++counter + $"  {Thread.CurrentThread.GetHashCode()}");
        Thread.Sleep(400);
    }
}

async Task PrintCounterAsync()
{
    await Task.Run(() => { PrintCounter(); });
}
