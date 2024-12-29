using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.WebUI.ViewComponents
{
    public class _MainNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
