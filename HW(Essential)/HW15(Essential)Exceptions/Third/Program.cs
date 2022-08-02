using Third;

Price[] prices = new Price[2];

for (int i = 0; i < prices.Length; i++)
{
    prices[i].Name = Console.ReadLine();
    prices[i].Store = Console.ReadLine();
    prices[i].ProdPrice = Int32.Parse(Console.ReadLine());
}

Console.Write("Enter the name of store: ");
string Name = Console.ReadLine();
bool check = false;

foreach (var item in prices.OrderBy(x => x.Store))
{
    if (item.Store == Store)
    {
        Console.Write(item.Name + " " + item.ProdPrice);
        check = true;
    }
}

if (check != true)
{
    throw new Exception("There is no products");
}
