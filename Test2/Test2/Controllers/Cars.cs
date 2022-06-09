using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test2.Services;

namespace Test2.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class Cars : ControllerBase
    {
        private readonly ICarsService _servicesService;

        public Cars(ICarsService controllerService)
        {
            _servicesService = controllerService;
        }
        [HttpPut("{idCar}/{idInspection}")]
        public async Task<IActionResult> ChangeCarAssignedToService(int idCar, int idInspection) {
            var result = await _servicesService.ChangeCarAssignedToService(idCar, idInspection);
            if (result.Equals("Car not found!"))
                return NotFound(result);
            if (result.Equals("Inspection not found!"))
                return NotFound(result);
            if (result.Equals("This car is already assigned to this inspection!"))
                return BadRequest(result);
            if (result.Equals("Inspection already started!"))
                return BadRequest(result);
            
            return Ok(result);
        }
    }
}
