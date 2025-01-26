using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public sealed class CarController : ControllerBase
    {
        [HttpPost]
        public static Task<IActionResult> AddCar([FromBody] CarRequest request)
        {
            return Task.FromResult<IActionResult>(new ObjectResult(request));
        }
    }
}
