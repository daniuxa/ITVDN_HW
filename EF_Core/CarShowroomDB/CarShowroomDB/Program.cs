using CarShowroomDB;
using CarShowroomDbData;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<CarShowroomContext>();
var options = optionsBuilder.Options;

DMLCommands.BrandsWithMostSalesOfElectricCars(options, new DateTime(1970, 1, 1), DateTime.Now);