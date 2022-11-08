namespace CarShowroomDomain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FName { get; set; } = String.Empty;
        public string MName { get; set; } = String.Empty;
        public string LName { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string? Email { get; set; }

        public List<Order> Orders { get; set; } = new();
    }
}
