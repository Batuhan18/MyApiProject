using Microsoft.AspNetCore.Mvc;
using MyApiProject.WebUI.Dtos.AboutDtos;
using MyApiProject.WebUI.Dtos.ProductDtos;
using Newtonsoft.Json;

namespace MyApiProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7105/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDtos>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
