using Microsoft.AspNetCore.Mvc;

namespace BulkWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
