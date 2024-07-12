using Microsoft.AspNetCore.Mvc;
using ValeFinanceWeb.Dtos;
using ValeFinanceWeb.Interface;

namespace ValeFinanceWeb.Controllers
{
    public class InterestController : Controller
    {
        private readonly IInterestRateRepository _repository;

        public InterestController(IInterestRateRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("interest-rates")]
        public async Task<ActionResult<InterestRateDto>> GetAllInterestRates()
        {
            var interestRates = await _repository.GetAllInterestRatesAsync();
            var interestRateDTOs = interestRates.Select(r => new InterestRateDto
            {
                MinAmount = r.MinAmount,
                MaxAmount = r.MaxAmount,
                MinDays = r.MinDays,
                MaxDays = r.MaxDays,
                Interest = r.Interest
            });
            return Ok(interestRateDTOs);
        }

        [HttpPost("calculate-interest")]
        public async Task<ActionResult<InterestCalculationResponseDto>> CalculateInterest([FromBody] InterestCalculationRequestDto request)
        {
            try
            {
                var interestRate = await _repository.GetApplicableInterestRateAsync(request.Amount, request.DurationInDays);
                if (interestRate == null)
                {
                    return NotFound("No applicable interest rate found.");
                }

                var interest = request.Amount * (interestRate.Interest / 100) * request.DurationInDays / 365;
                return Ok(new InterestCalculationResponseDto { Interest = interest });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while calculating interest: {ex.Message}");
            }
        }
    }
}
