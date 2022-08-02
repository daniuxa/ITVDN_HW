using Second;
Worker[] workers = new Worker[5];

for (int i = 0; i < workers.Length; i++)
{
    Console.WriteLine($"Enter data {i + 1} worker");
    Console.Write("Name: ");
    workers[i].Name = Console.ReadLine();
    Console.Write("Position: ");
    workers[i].Position = Console.ReadLine();
    while (true)
    {
        Console.Write("Start working year: ");
        try
        {
            workers[i].StartWorkingYear = Int32.Parse(Console.ReadLine());
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

foreach (var item in workers.OrderBy(x => x.Name))
{
    Console.WriteLine(item.Name);
}

Console.WriteLine(new String('-', 10));

Console.Write("Enter the experience: ");
int Exp = Int32.Parse(Console.ReadLine());
foreach (var item in workers.OrderBy(x => x.Name))
{
    if (DateTime.Now.Year - item.StartWorkingYear >= Exp)
    {
        Console.WriteLine(item.Name);
    }
}

