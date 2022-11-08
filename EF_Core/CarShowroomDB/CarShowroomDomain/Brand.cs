namespace CarShowroomDomain
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; } = String.Empty;

        public Company Company { get; set; } = null!;
        public int CompanyId { get; set; } 

        public List<Model> Models { get; set; } = new();
        public List<Automobile> Automobiles { get; set; } = new();
    }
}
