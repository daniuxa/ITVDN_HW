/*Реализуйте шаблон NVI в собственной иерархии наследования.*/

MyClass1 myClass = new MyClass1();
myClass.DoWork();

public class MyClass1
{
    public void DoWork()
    {
        Console.WriteLine("This is interface for user, to use my class and logic is hidden in others methods");
        PreDoWork();
        CoreDoWork();
    }
    protected virtual void CoreDoWork()
    {
        Console.WriteLine("Base work which my class do");
    }
    private void PreDoWork()
    {
        Console.WriteLine("I need to remake something in base class, this why I create this class");
    }
}

public class MyClass2 : MyClass1
{
    protected override void CoreDoWork()
    {
        Console.WriteLine("New work which my class do for user");
    }
}


