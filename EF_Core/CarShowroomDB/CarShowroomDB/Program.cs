using PubContext;

using (CarShowroomContext context = new CarShowroomContext())
{
    context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();
}
