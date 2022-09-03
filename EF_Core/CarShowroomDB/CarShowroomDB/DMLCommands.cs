using CarShowroomDomain;
using CarShowroomDbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDB
{
    static public class DMLCommands
    {
        static public void Add()
        {
            using (CarShowroomContext context = new CarShowroomContext())
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
                Model PassatB8 = new Model() { Name = "Passat B8", ProdYearFrom = 2015, ProdYearTo = "none", Brand = Volkswagen };
                Model A7 = new Model() { Name = "A7 2018", ProdYearFrom = 2018, ProdYearTo = "none", Brand = Audi };
                Model Camry = new Model() { Name = "Camry XV70", ProdYearFrom = 2017, ProdYearTo = "none", Brand = Toyota };
                Model Civic = new Model() { Name = "Civic 2021", ProdYearFrom = 2021, ProdYearTo = "none", Brand = Honda };

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

        static public void SelectFst()
        {

        }
    }
}
