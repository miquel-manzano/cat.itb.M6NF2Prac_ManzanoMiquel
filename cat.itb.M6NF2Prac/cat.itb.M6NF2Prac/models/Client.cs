namespace cat.itb.M6NF2Prac.models
{
    public class Client
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string? Name { get; set; }
        public decimal Credit { get; set; }
        public Client ClientRef { get; set; }
    }
}
