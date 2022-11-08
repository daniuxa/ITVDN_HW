namespace CarShowroomDomain
{
    public class Model
    {
        public int ModelId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int ProdYearFrom { get; set; }
        public int? ProdYearTo { get; set; }

        public Brand Brand { get; set; } = null!;
        public int BrandId { get; set; }

        public List<Equipment> Equipments { get; set; } = new();
        public List<Automobile> Automobiles { get; set; } = new();
    }
}
