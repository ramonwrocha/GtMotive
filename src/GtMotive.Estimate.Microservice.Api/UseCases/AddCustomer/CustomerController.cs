using System;
using System.Threading.Tasks;
using AutoMapper;
using GtMotive.Estimate.Microservice.Api.UseCases.AddCar;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCustomer
{
    [Route("api/[controller]")]
    public sealed class CustomerController(IAddCustomerUseCase addCustomerUseCase, IMapper mapepr) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            var command = mapepr.Map<AddCustomerInput>(request);

            await addCustomerUseCase.Execute(command);

            return new NoContentResult();
        }
    }
}
