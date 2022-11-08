namespace CarShowroomDomain
{
    public class Company
    {
        //Key
        public string Name { get; set; } = String.Empty;

        public string? SiteComp { get; set; }

        public List<Engine> Engines { get; set; } = new();
        public List<Brand> Brands { get; set; } = new();
    }
}
