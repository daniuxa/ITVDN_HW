namespace CarShowroomDomain
{
    public class Avaibility
    {
        public Automobile Automobile { get; set; } = null!;
        public string VINAuto { get; set; } = String.Empty;

        public CarShowroom CarShowroom { get; set; } = null!;
        public int CarShowroomId { get; set; }
    }
}
