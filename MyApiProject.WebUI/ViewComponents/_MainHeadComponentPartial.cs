using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.WebUI.ViewComponents
{
    public class _MainHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
