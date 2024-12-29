using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.WebUI.ViewComponents
{
    public class _MainProductComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
