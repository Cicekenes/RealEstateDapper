using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    /// <summary>
    /// HomePage
    /// </summary>
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
