using InjecaoDependencia.Application;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StartController : ControllerBase
    {
        private readonly ILogger<StartController> _logger;
        private readonly IApplicationOne _appOne;
        private readonly IApplicationTwo _appTwo;

        public StartController(ILogger<StartController> logger, IApplicationOne appOne, IApplicationTwo appTwo)
        {
            _logger = logger;
            _appOne = appOne;
            _appTwo = appTwo;
        }

        [HttpPost]
        public IActionResult Index()
        {
            _appOne.Print(1);
            _appTwo.Print(2);

            return Ok();
        }
    }
}