using HW16_Essential_;
/*Point a = new Point() { X = 1, Y = 1, Z = 1 };
Point b = new Point() { X = 3, Y = 2, Z = 2 };

Console.WriteLine(a + b);*/

/*Block a = new Block() { A = 2, B = 1, C = 1, D = 1 };
Block b = new Block() { A = 1, B = 1, C = 1, D = 1 };

Console.WriteLine(a.Equals(b));
Console.WriteLine(a);*/

/*House original = new House() { Adress = "House1", Price = 100000};
House? newHouse = original.Clone() as House;
newHouse.Adress = "House2";

Console.WriteLine(original);
Console.WriteLine(newHouse);
Console.WriteLine(new String('-', 10));

newHouse = original.NonDeepClone() as House;
newHouse.Adress = "House2";

Console.WriteLine(original);
Console.WriteLine(newHouse);*/

Date date1 = new Date() { Day = 20, Month = 10, Year = 2022};
Date date2 = new Date() { Day = 11, Month = 5, Year = 2021 };

Console.WriteLine(date1 - date2);
TimeSpan date = new DateTime(date1.Year, date1.Month, date1.Day) - new DateTime(date2.Year, date2.Month, date2.Day);
Console.WriteLine(date.TotalDays);

Date date3 = date1 + 12;
Console.WriteLine(date3);