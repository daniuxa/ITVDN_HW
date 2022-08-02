File.WriteAllLines(@"D:\text.txt", new string[] {"Hello world!"});

Console.ReadKey();

string[] str = File.ReadAllLines(@"D:\text.txt");

foreach (var item in str)
{
    Console.WriteLine(item);
}