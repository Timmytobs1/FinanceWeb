using ValeFinanceWeb.Dtos;
using ValeFinanceWeb.Models;

namespace ValeFinanceWeb.Mappers
{
    public static class InterestRateMapper
    {
        public static InterestRateDto ToDTO(InterestRate interestRate)
        {
            return new InterestRateDto
            {
                MinAmount = interestRate.MinAmount,
                MaxAmount = interestRate.MaxAmount,
                MinDays = interestRate.MinDays,
                MaxDays = interestRate.MaxDays,
                Interest = interestRate.Interest
            };
        }

        public static InterestRate ToEntity(InterestRateDto dto)
        {
            return new InterestRate
            {
                MinAmount = dto.MinAmount,
                MaxAmount = dto.MaxAmount,
                MinDays = dto.MinDays,
                MaxDays = dto.MaxDays,
                Interest = dto.Interest
            };
        }
    }

}
