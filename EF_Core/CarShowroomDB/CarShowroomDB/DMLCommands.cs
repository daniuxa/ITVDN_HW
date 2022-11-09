using CarShowroomDomain;
using CarShowroomDbData;
using Microsoft.EntityFrameworkCore;

namespace CarShowroomDB
{
    static public class DMLCommands
    {
        static private DbContextOptionsBuilder<CarShowroomContext> optionsBuilder = new DbContextOptionsBuilder<CarShowroomContext>();
        static private DbContextOptions options = optionsBuilder.Options;
        static public void Add()
        {
            using (CarShowroomContext context = new CarShowroomContext(options))
            {
                #region Companies
                Company VAG = new Company() { Name = "VAG", SiteComp = "vag-group.com" };
                Company ToyotaComp = new Company() { Name = "Toyota", SiteComp = "Toyota.com" };
                Company HondaComp = new Company() { Name = "Honda", SiteComp = "Honda.com" };

                context.Companies.AddRange(VAG, ToyotaComp, HondaComp);
                #endregion

                #region Brands
                Brand Volkswagen = new Brand() { Name = "Volkswagen", Company = VAG };
                Brand Audi = new Brand() { Name = "Audi", Company = VAG };
                Brand Toyota = new Brand() { Name = "Toyota", Company = ToyotaComp };
                Brand Honda = new Brand() { Name = "Honda", Company = HondaComp };

                context.Brands.AddRange(Volkswagen, Audi, Toyota, Honda);
                #endregion

                #region Models
                Model PassatB8 = new Model() { Name = "Passat B8", ProdYearFrom = 2015, Brand = Volkswagen };
                Model A7 = new Model() { Name = "A7 2018", ProdYearFrom = 2018, Brand = Audi };
                Model Camry = new Model() { Name = "Camry XV70", ProdYearFrom = 2017, Brand = Toyota };
                Model Civic = new Model() { Name = "Civic 2021", ProdYearFrom = 2021, Brand = Honda };

                context.Models.AddRange(PassatB8, A7, Camry, Civic);
                #endregion

                #region Engines
                Engine CJSA = new Engine() { Name = "CJSA", EngineCapacity = 2.0, Power = 180, FuelType = "Gasoline", Company = VAG };
                Engine DLZA = new Engine() { Name = "DLZA", EngineCapacity = 3.0, Power = 340, FuelType = "Gasoline", Company = VAG };
                Engine GRFKS2 = new Engine() { Name = "2GR-FKS", EngineCapacity = 3.5, Power = 249, FuelType = "Gasoline", Company = ToyotaComp };
                Engine R18A1 = new Engine() { Name = "R18A1", EngineCapacity = 1.8, Power = 140, FuelType = "Gasoline", Company = HondaComp };

                context.Engines.AddRange(CJSA, DLZA, GRFKS2, R18A1);
                #endregion

                #region Equipments
                Equipment ComfortlineB8 = new Equipment() { Name = "Comfortline", Engine = CJSA, Gearbox = "Automat", Model = PassatB8, Price = 25000, Transmission = "FWD" };
                Equipment BaseA7 = new Equipment() { Name = "Base", Engine = DLZA, Gearbox = "Automat", Model = A7, Price = 61000, Transmission = "AWD" };
                Equipment LuxCamry = new Equipment() { Name = "Lux", Engine = GRFKS2, Gearbox = "Automat", Model = Camry, Price = 38000, Transmission = "FWD" };

                context.Equipments.AddRange(ComfortlineB8, BaseA7, LuxCamry);
                #endregion

                #region Automobiles
                Automobile VolkswagenB8 = new Automobile() { VIN = "YAUQRW34GEN060121", Brand = Volkswagen, Model = PassatB8, Equipment = ComfortlineB8, ProdDate = new DateTime(2018, 9, 11), BodyType = "Sedan", Color = "Grey"  };
                Automobile AudiA7 = new Automobile() { VIN = "TRGQRW44GEN960121", Brand = Audi, Model = A7, Equipment = BaseA7, ProdDate = new DateTime(2019, 10, 19), BodyType = "Sedan", Color = "Black" };
                Automobile ToyotaCamry = new Automobile() { VIN = "YOOQWE44GEN060121", Brand = Toyota, Model = Camry, Equipment = LuxCamry, ProdDate = new DateTime(2021, 11, 1), BodyType = "Sedan", Color = "Black" };

                context.Automobiles.AddRange(VolkswagenB8, AudiA7, ToyotaCamry);
                #endregion

                context.SaveChanges();
            }

        }

        static public void Update()
        {
            using (CarShowroomContext context = new CarShowroomContext(options))
            {
                var automobiles = context.Automobiles;
                Automobile? automobile = automobiles.Where(x => x.Color == "Black").FirstOrDefault();
                if (automobile != null)
                {
                    automobile.Color = "Blue";
                }
            }
        }

        static public void SelectFst()
        {
            using (CarShowroomContext context = new CarShowroomContext(options))
            {
                var Distinct = context.Automobiles.Select(y => new
                {
                    BodyType = y.BodyType
                }).Distinct();

                foreach (var item in Distinct)
                {
                    Console.WriteLine(item.BodyType);
                }

                Console.WriteLine(new String('-', 40));

                var Second = context.Automobiles.Skip(1).Take(1);
                foreach (var item in Second)
                {
                    Console.WriteLine(item.BodyType);
                }

                Console.WriteLine(new String('-', 40));

                var third = context.Automobiles.Include(x => x.Brand).Where(x => x.ProdDate < DateTime.Now && x.ProdDate > new DateTime(2020, 1, 1)).ToList();

                foreach (var item in third)
                {
                    Console.WriteLine(item.Brand.Name);
                }

                Console.WriteLine(new String('-', 40));

                //var frth = context.Automobiles.Join().Where(x => x.ProdDate < DateTime.Now && x.ProdDate > new DateTime(2020, 1, 1)).ToList();
                var frth = from automobile in context.Automobiles
                           join brand in context.Brands on automobile.BrandId equals brand.BrandId
                           where automobile.ProdDate < DateTime.Now && automobile.ProdDate > new DateTime(2020, 1, 1)
                           select new
                           {
                               BrandName = brand.Name
                           };
                foreach (var item in frth)
                {
                    Console.WriteLine(item.BrandName);
                }

                Console.WriteLine(new String('-', 40));

                var fifth = context.Automobiles.Include(x => x.Brand).Where(x => EF.Functions.Like(x.BodyType, "Se%")).ToList();

                foreach (var item in fifth)
                {
                    Console.WriteLine(item.Brand.Name);
                }
            }
        }

        static public void SelectSnd()
        {
            using (CarShowroomContext context = new CarShowroomContext(options))
            {
                var Union = context.Automobiles.Select(p => new { ProdYear = p.ProdDate.Year}).Union(context.Models.Select(y => new {ProdYear = y.ProdYearFrom})).ToList();

                foreach (var item in Union)
                {
                    Console.WriteLine(item.ProdYear);
                }

                Console.WriteLine(new String('-', 40));

                var GroupBy = from company in context.Companies
                              join brand in context.Brands on company.Name equals brand.Company.Name
                              group company by company.Name into g
                              select new
                              {
                                  g.Key,
                                  Count = g.Count()
                              };
                foreach (var item in GroupBy)
                {
                    Console.WriteLine(item.Key + " " + item.Count);
                }

                Console.WriteLine(new String('-', 40));

                var GroupByInclude = context.Companies.Include(x => x.Brands).GroupBy(x => x.Name).Select(x => new
                {
                    Key = x.Key,
                    Count = x.Count()
                });
            
                foreach (var item in GroupByInclude)
                {
                    Console.WriteLine(item.Key + " " + item.Count);
                }
            }
        }

        static public void SelectAgregate()
        {
            using (CarShowroomContext context = new CarShowroomContext(options))
            {
                int AmountCars = context.Automobiles.Count();
                Console.WriteLine(AmountCars);

                Console.WriteLine(new String('-', 80));

                int MinPrice = (int)context.Equipments.Min(x => x.Price);
                int MaxPrice = (int)context.Equipments.Max(x => x.Price);
                int AvgPrice = (int)context.Equipments.Average(x => x.Price);
                int SumPrice = (int)context.Equipments.Sum(x => x.Price);
                Console.WriteLine("Min: " + MinPrice);
                Console.WriteLine("Max: " + MaxPrice);
                Console.WriteLine("Avg: " + AvgPrice);
                Console.WriteLine("Sum: " + SumPrice);
            }
        }
    }
}
