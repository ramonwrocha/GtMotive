using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    [Route("api/[controller]")]
    public sealed class CarController(IAddCarUseCase addCarUseCase) : ControllerBase
    {
        private readonly IAddCarUseCase _addCarUseCase = addCarUseCase;

        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] CarRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            await _addCarUseCase.Execute(new AddCarInput
            {
                LicensePlate = request.LicensePlate,
                Brand = request.Brand,
                Model = request.Model,
                ManufacturingDate = request.ManufacturingDate,
                Available = request.Available
            });

            return new NoContentResult();
        }
    }
}
