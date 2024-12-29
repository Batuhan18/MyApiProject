using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.WebUI.ViewComponents
{
    public class _MainScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
