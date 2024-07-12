using ValeFinanceWeb.Models;

namespace ValeFinanceWeb.Interface
{
    public interface IInterestRateRepository
    {
       public Task<IEnumerable<InterestRate>> GetAllInterestRatesAsync();
       public Task<InterestRate> GetApplicableInterestRateAsync(decimal amount, int durationInDays);
    }
}
