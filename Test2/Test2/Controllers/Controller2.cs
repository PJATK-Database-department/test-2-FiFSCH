using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test2.Services;

namespace Test2.Controllers
{
    [Route("api/c1")]
    [ApiController]
    public class Controller2 : ControllerBase
    {
        private readonly IController2Service _controllerService;

        public Controller2(IController2Service controllerService)
        {
            _controllerService = controllerService;
        }
    }
}
