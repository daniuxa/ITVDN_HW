/*Напишите небольшую программу на языке C#, представляющую собой абстрактную
реализацию данного шаблона.*/

Programmer programmer = new Programmer();
Admin admin = new Admin();

programmer.Work();
admin.Work();

public class Programmer : Worker
{

    public void MakeCode()
    {
        Console.WriteLine("Proging");
    }

    public override void Work()
    {
        Console.WriteLine("Programmer work");
    }

    public override void GetSalary()
    {
        Console.WriteLine("5000$");
    }
}


public class Admin : Worker
{
    public void CheckStaff()
    {
        Console.WriteLine("Checking");
    }

    public override void Work()
    {
        Console.WriteLine("Admin work");
    }

    public override void GetSalary()
    {
        Console.WriteLine("2000$");
    }
}

public abstract class Worker
{
    public abstract void Work();
    public abstract void GetSalary();
}