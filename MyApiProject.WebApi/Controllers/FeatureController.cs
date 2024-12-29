using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.BusinessLayer.Abstract;
using MyApiProject.DtosLayer.FeatureDtos;
using MyApiProject.EntityLayer.Concrete;

namespace MyApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _featureService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDtos createFeatureDtos)
        {
            Feature feature = new Feature();
            feature.Title = createFeatureDtos.Title;
            feature.Head = createFeatureDtos.Head;
            feature.ImageUrl = createFeatureDtos.ImageUrl;
            _featureService.TInsert(feature);
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
            return Ok("Silme Başarılı");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var values = _featureService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDtos updateFeatureDtos)
        {
            Feature feature = new Feature();
            feature.FeatureId = updateFeatureDtos.FeatureId;
            feature.Title = updateFeatureDtos.Title;
            feature.Head = updateFeatureDtos.Head;
            feature.ImageUrl = updateFeatureDtos.ImageUrl;
            _featureService.TUpdate(feature);
            return Ok("Güncelleme Başarılı");
        }
    }
}
