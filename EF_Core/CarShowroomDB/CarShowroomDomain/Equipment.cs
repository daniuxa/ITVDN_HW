namespace CarShowroomDomain
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string Gearbox { get; set; } = String.Empty;
        public string Transmission { get; set; } = String.Empty;

        public Engine Engine { get; set; } = null!;
        public int EngineId { get; set; }

        public Model Model { get; set; } = null!;
        public int ModelId { get; set; }

        public List<Automobile> Automobiles { get; set; } = new();
    }
}
