namespace CarShowroomDomain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = String.Empty;
        public DateTime PurchaseDateTime { get; set; }

        public Client Client { get; set; } = null!;
        public int ClientId { get; set; }

        public string VinAuto { get; set; } = String.Empty;
        public Automobile Automobile { get; set; } = null!;

        public List<Worker> Workers { get; set; } = new();
    }
}
