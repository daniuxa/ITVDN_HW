using Second;

Monthes pairs = new Monthes();

foreach (var pair in pairs)
{
    Console.WriteLine(pair.Key + " " + pair.Value);
}

foreach (var item in pairs[31])
{
    Console.WriteLine(item);
}
