using Microsoft.AspNetCore.Mvc;

namespace Heroku.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Ping")]
        public string Ping()
        {
            return "Pong";
        }
    }
}