using Second;

List<Car> cars = new List<Car>();
List<Order> orders = new List<Order>();
cars.Add(new Car() { Brand = "BMW", Model = "M3", ProdYear = 2018, Color = "Black"});
cars.Add(new Car() { Brand = "Audi", Model = "A3", ProdYear = 2016, Color = "Blue" });
cars.Add(new Car() { Brand = "Opel", Model = "Astra", ProdYear = 2015, Color = "Green" });

orders.Add(new Order() { Brand = "BMW", Name = "Salivon", Phone = "0636792120" });
orders.Add(new Order() { Brand = "Audi", Name = "Tarasyk", Phone = "0676792120" });
orders.Add(new Order() { Brand = "Opel", Name = "Shevchenko", Phone = "0936792120" });

var linq = from car in cars
           join order in orders
           on car.Brand equals order.Brand
           select new
           {
               Brand = car.Brand,
               Model = car.Model,
               ProdYear = car.ProdYear,
               Color = car.Color,
               Name = order.Name
           };
var linq1 = cars.Join(orders, order => order.Brand, car => car.Brand, (order, car) => new { Order = order.Brand, Car = car.Brand});

foreach (var item in linq1)
{
    Console.WriteLine(item.Car + " " + item.Order);
}

/*foreach (var item in linq)
{
    Console.WriteLine(item.Brand + " " + item.Model + " " + item.ProdYear + " " + item.Color + " " + item.Name);
}*/
