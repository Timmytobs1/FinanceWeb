namespace ValeFinanceWeb.Models
{
    public class InterestRate
    {
        public int Id { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public int MinDays { get; set; }
        public int MaxDays { get; set; }
        public decimal Interest { get; set; }
    
    }
}
