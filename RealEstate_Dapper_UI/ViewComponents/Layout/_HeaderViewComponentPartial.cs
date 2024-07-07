using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Layout
{
    /// <summary>
    /// Partial View gibi görev görmektedir.
    /// </summary>
    public class _HeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
