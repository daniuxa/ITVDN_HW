/*Создайте два метода, которые будут выполняться в рамках параллельных задач. Организуйте
вызов этих методов при помощи Invoke таким образом, чтобы основной поток программы
(метод Main) не остановил свое выполнение.*/

Task task = new Task( () => Parallel.Invoke(Method1, Method2));
task.Start();

for (int i = 0; i < 80; i++)
{
    Thread.Sleep(100);
    Console.Write("M ");
}






void Method1()
{
    for (int i = 0; i < 80; i++)
    {
        Thread.Sleep(100);
        Console.Write("1 ");
    }
}

void Method2()
{
    for (int i = 0; i < 80; i++)
    {
        Thread.Sleep(100);
        Console.Write("2 ");
    }
}
