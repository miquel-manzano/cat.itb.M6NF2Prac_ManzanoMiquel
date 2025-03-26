namespace cat.itb.M6NF2Prac.models
{
    public class Orderprod
    {
        public int ID { get; set; }
        public Product Product { get; set; } // Product ID
        public Client Client { get; set; } // Client ID
        public DateTime Orderdate { get; set; }
        public int Amount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Cost { get; set; }
    }
}
