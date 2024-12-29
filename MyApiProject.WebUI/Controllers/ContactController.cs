using Microsoft.AspNetCore.Mvc;
using MyApiProject.WebUI.Dtos.AboutDtos;
using MyApiProject.WebUI.Dtos.ContactDtos;
using Newtonsoft.Json;

namespace MyApiProject.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7105/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDtos>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
