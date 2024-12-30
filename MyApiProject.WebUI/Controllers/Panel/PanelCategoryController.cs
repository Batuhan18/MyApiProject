using Microsoft.AspNetCore.Mvc;
using MyApiProject.DtosLayer.CategoryDtos;
using Newtonsoft.Json;
using System.Text;

namespace MyApiProject.WebUI.Controllers.Panel
{
    public class PanelCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PanelCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> List()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7105/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultCategoryDtos>>(jsonData);
                return View(value);
            }
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        public async Task<IActionResult> CreateCategory(CreateCategoryDtos createCategoryDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCategoryDtos);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7105/api/Category", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7105/api/Category?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7105/api/Category{id}");
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryDtos>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDtos updateCategoryDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCategoryDtos);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7105/api/Category", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
