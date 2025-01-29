using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.RentCar
{
    [Route("api/[controller]")]
    public sealed class RentalOrderController(IRentCarUseCase rentCarUseCase) : ControllerBase
    {
        [HttpPost("createOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] RentalOrderRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            var model = new RentCarInput
            {
                DocumentNumberCustomer = request.DocumentNumberCustomer,
                CarLicensePlate = request.CarLicensePlate,
                RentalStartDate = request.RentalStartDate.Value,
                RentalEndDate = request.RentalEndDate.Value,
                TotalPrice = 0
            };

            await rentCarUseCase.Execute(model);

            return new NoContentResult();
        }
    }
}
