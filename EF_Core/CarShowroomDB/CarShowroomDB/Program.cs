using CarShowroomDbData;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<CarShowroomContext>();
var options = optionsBuilder.Options;
