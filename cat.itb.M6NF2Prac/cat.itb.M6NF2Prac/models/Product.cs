namespace cat.itb.M6NF2Prac.models
{
    public class Product
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string? Description { get; set; }
        public int CurrentStock { get; set; }
        public int MinStock { get; set; }
        public decimal Price { get; set; }
        public Salesperson SalesP {  get; set; } // id salesperson
        public Product ProductRef { get; set; }
    }
}
