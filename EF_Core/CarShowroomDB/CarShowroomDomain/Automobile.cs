
namespace CarShowroomDomain
{
    public class Automobile
    {
        //Key
        public string VIN { get; set; } = String.Empty;

        public DateTime ProdDate { get; set; }
        public string BodyType { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();

        //Relation directly to CarShowoom table
        public List<CarShowroom> CarShowrooms { get; set; } = new();
        //Relation through the table Avaibility to CarShowroomtable 
        public List<Avaibility> Avaibilities { get; set; } = new();

        public Brand Brand { get; set; } = null!; //not null field
        public int BrandId { get; set; }

        public Model Model { get; set; } = null!;
        public int ModelId { get; set; }

        public Equipment Equipment { get; set; } = null!;
        public int EquipmentId { get; set; }
    }
}
