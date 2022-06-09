using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test2.Services;

namespace Test2.Controllers
{
    [Route("api/c2")]
    [ApiController]
    public class Controller1 : ControllerBase
    {
        private readonly IControllerService _controllerService;

        public Controller1(IControllerService controllerService)
        {
            _controllerService = controllerService;
        }
        
    }
}
