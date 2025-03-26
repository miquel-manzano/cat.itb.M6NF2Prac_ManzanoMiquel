namespace cat.itb.M6NF2Prac.models
{
    public class Salesperson
    {
        public int ID { get; set; }
        public string? Surename { get; set; }
        public string? Job {  get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public decimal? Commission { get; set; }
        public string? Dep {  get; set; }
        public Salesperson SalespersonRef { get; set; }
    }
}
