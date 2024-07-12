using Microsoft.EntityFrameworkCore;
using ValeFinanceWeb.Models;

namespace ValeFinanceWeb.Data
{
    public class ValeFinanceContext : DbContext
    {

        public ValeFinanceContext(DbContextOptions<ValeFinanceContext> options) : base(options)
        {
        }

        public DbSet<InterestRate> InterestRates { get; set; }
    }
}


