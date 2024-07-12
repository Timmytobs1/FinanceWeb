namespace ValeFinanceWeb.Dtos
{
    public class InterestCalculationRequestDto
    {
        public decimal Amount { get; set; }
        public int DurationInDays { get; set; }
    }
}
