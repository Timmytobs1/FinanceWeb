namespace ValeFinanceWeb.Dtos
{
    public class InterestRateDto
    {

        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public int MinDays { get; set; }
        public int MaxDays { get; set; }
        public decimal Interest { get; set; }
    }
}
