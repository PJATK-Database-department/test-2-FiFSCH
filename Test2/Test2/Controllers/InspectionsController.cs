using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test2.Services;

namespace Test2.Controllers
{
    [Route("api/inspections")]
    [ApiController]
    public class InspectionsController : ControllerBase
    {
        private readonly IInspectionsService _inspectionsService;

        public InspectionsController(IInspectionsService controllerService)
        {
            _inspectionsService = controllerService;
        }
        [HttpGet("{idInspection}")]
        public async Task<IActionResult> GetInspection(int idInspection) {
            var result = await _inspectionsService.GetInspection(idInspection);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        
    }
}
