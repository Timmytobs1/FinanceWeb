using Microsoft.EntityFrameworkCore;
using ValeFinanceWeb.Data;
using ValeFinanceWeb.Interface;
using ValeFinanceWeb.Models;

namespace ValeFinanceWeb.Repository
{
    public class InterestRateRepository  : IInterestRateRepository
    {
        private readonly ValeFinanceContext _context;

        public InterestRateRepository(ValeFinanceContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InterestRate>> GetAllInterestRatesAsync()
        {
            return await _context.InterestRates.ToListAsync();
        }

        public async Task<InterestRate> GetApplicableInterestRateAsync(decimal amount, int durationInDays)
        {
            return await _context.InterestRates
                .FirstOrDefaultAsync(r => r.MinAmount <= amount && r.MaxAmount >= amount
                  && r.MinDays <= durationInDays && r.MaxDays >= durationInDays);
        }
    }
}
