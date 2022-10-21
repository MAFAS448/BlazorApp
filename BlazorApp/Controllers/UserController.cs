using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly BlazordbContext _DbContext;
        public UserController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
