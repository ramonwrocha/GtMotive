using System.Threading.Tasks;
using AutoMapper;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.GetAvailableCars;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.GetAvailableCars
{
    [Route("api/[controller]")]
    public class CarController(IGetAvailableCarsUseCase getAvailableCarsUseCase, IMapper mapper) : ControllerBase
    {
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableCars()
        {
            var result = await getAvailableCarsUseCase.GetAvailable();

            var response = mapper.Map<AvailableCarsResponse>(result);

            return new ObjectResult(response);
        }
    }
}
