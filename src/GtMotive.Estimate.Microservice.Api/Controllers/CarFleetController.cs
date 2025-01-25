using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarFleetController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetAllCars()
        {
            throw new NotImplementedException();
        }
    }
}
