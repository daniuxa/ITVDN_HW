using CarShowroomDbData;

using (CarShowroomContext context = new CarShowroomContext())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}
