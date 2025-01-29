using System;
using System.Threading.Tasks;
using AutoMapper;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    [Route("api/[controller]")]
    public sealed class CarController(IAddCarUseCase addCarUseCase, IMapper mapepr) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] CarRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            var command = mapepr.Map<AddCarInput>(request);

            await addCarUseCase.Execute(command);

            return new NoContentResult();
        }
    }
}
