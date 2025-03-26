namespace cat.itb.M6NF2Prac.models
{
    public class Provider
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? StCode { get; set; }
        public string? ZipCode { get; set; }
        public int Area { get; set; }
        public string? Phone { get; set; }
        public Product Product { get; set; } // Product Id
        public int Amount { get; set; }
        public decimal Credit { get; set; }
        public string? Remark { get; set; }
    }
}
