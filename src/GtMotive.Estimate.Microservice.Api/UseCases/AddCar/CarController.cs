using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    [Route("api/[controller]")]
    public sealed class CarController(IAddCarUseCase addCarUseCase) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] CarRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            var model = new AddCarInput
            {
                LicensePlate = request.LicensePlate,
                Brand = request.Brand,
                Model = request.Model,
                ManufacturingDate = (DateTime)request.ManufacturingDate,
                Available = (bool)request.Available
            };

            await addCarUseCase.Execute(model);

            return new NoContentResult();
        }
    }
}
