namespace CarShowroomDomain
{
    public class CarShowroom
    {
        public int CarShowroomId { get; set; }
        public string City { get; set; } = String.Empty;
        public string Street { get; set; } = String.Empty;
        public string House { get; set; } = String.Empty;

        public List<Worker> Workers { get; set; } = new();
        public List<Automobile> Automobiles { get; set; } = new();
        public List<Avaibility> Avaibilities { get; set; } = new();

    }
}
