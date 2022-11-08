namespace CarShowroomDomain
{
    public class Engine
    {
        public int EngineId { get; set; }
        public string Name { get; set; } = String.Empty;
        public double EngineCapacity { get; set; }
        public int Power { get; set; }
        public string FuelType { get; set; } = String.Empty;

        public Company Company { get; set; } = null!;
        public int CompanyId { get; set; }

        public List<Equipment> Equipments { get; set; } = new();
    }
}
