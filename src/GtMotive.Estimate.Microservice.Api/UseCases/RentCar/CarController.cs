using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.RentCar
{
    [Route("api/[controller]")]
    public sealed class CarController(IRentCarUseCase addCarUseCase, IMapper mapepr) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            var command = mapepr.Map<AddCustomerInput>(request);

            await addCarUseCase.Execute(command);

            return new NoContentResult();
        }
    }
}
