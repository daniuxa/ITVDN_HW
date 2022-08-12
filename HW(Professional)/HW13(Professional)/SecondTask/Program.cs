/*Создайте консольное приложение, в котором организуйте асинхронный вызов метода.
Используя конструкцию BeginInvoke передайте в поток некоторую информацию (возможно, в
формате строки). Организуйте обработку переданных данных в callback методе.*/


Func<int, int, int> func = Sum;
func.BeginInvoke(1, 2, Callback, func);

int Sum(int a, int b)
{
    Thread.Sleep(5000);
    return a + b;
}

void Callback(IAsyncResult asyncResult)
{
    Func<int, int, int>? func = asyncResult.AsyncState as Func<int, int, int>;
    if (func != null)
    {
        Console.WriteLine(func.EndInvoke(asyncResult));
    }
}
