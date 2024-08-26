using Microsoft.AspNetCore.Mvc;

namespace poc_dotnet_nginx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["APP_NAME"] = _configuration.GetValue<string>("APP_NAME");
            ViewData["HOST_NAME"] = Request.Host.Value;
            ViewData["MACHINE_NAME"] = Environment.MachineName;          

            return View();
        }
    }
}
