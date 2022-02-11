using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
