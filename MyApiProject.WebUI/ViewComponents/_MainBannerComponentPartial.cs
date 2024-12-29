using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.WebUI.ViewComponents
{
    public class _MainBannerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
