using Microsoft.AspNetCore.Mvc;
using MyApiProject.DtosLayer.AboutDtos;
using MyApiProject.WebUI.Dtos.AboutDtos;
using Newtonsoft.Json;
using System.Text;
using CreateAboutDtos = MyApiProject.DtosLayer.AboutDtos.CreateAboutDtos;

namespace MyApiProject.WebUI.Controllers.Panel
{
    public class PanelAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PanelAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> List()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7105/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultAboutDtos>>(jsonData);
                return View(value);
            }
            return View();
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDtos createAboutDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createAboutDtos);
            StringContent sc = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7105/api/About", sc);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7105/api/About?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7105/api/About" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutDtos>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDtos updateAboutDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutDtos);
            StringContent sc = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7105/api/About", sc);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
