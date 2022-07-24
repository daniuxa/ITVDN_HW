using HW14_Essential_Collections2;

/*MyList<int> list = new MyList<int>();
list.Add(1);
list.Add(2);
list.Add(3);

foreach (var item in list)
{
    Console.WriteLine(item);
}
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.Length);*/

/*MyList2<int> vs = new MyList2<int>();
vs.Add(1);
vs.Add(2);
vs.Add(3);

foreach (var item in vs)
{
    Console.WriteLine(item);
}
foreach (var item in vs)
{
    Console.WriteLine(item);
}*/

/*MyDictionary<int, int> nodeStructs = new MyDictionary<int, int>();
nodeStructs.Add(1, 11);
nodeStructs.Add(2, 22);
nodeStructs.Add(3, 33);
nodeStructs.Add(4, 44);

foreach (var item in nodeStructs)
{
    Console.WriteLine(item.key + " " + item.value);
}*/

MyList<int> list = new MyList<int>();

list.Add(1);
list.Add(2);
list.Add(3);

foreach (var item in list.GetArray())
{
    Console.WriteLine(item);
}