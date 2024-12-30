using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.BusinessLayer.Abstract;
using MyApiProject.DtosLayer.AboutDtos;
using MyApiProject.EntityLayer.Concrete;

namespace MyApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDtos createAboutDtos)
        {
            About about = new About();
            about.OurStory = createAboutDtos.OurStory;
            about.OurMission = createAboutDtos.OurMission;
            about.Image1 = createAboutDtos.Image1;
            about.Image2 = createAboutDtos.Image2;
            _aboutService.TInsert(about);
            return Ok("İşlem başarılı");
        }
        [HttpDelete]
        public IActionResult CreateDelete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Silme Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDtos updateAboutDtos)
        {
            About about = new About();
            about.AboutId = updateAboutDtos.AboutId;
            about.OurStory = updateAboutDtos.OurStory;
            about.OurMission = updateAboutDtos.OurMission;
            about.Image1 = updateAboutDtos.Image1;
            about.Image2 = updateAboutDtos.Image2;
            _aboutService.TUpdate(about);
            return Ok("Güncelleme Başarılı");
        }
    }
}
