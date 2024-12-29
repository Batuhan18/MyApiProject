using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.BusinessLayer.Abstract;
using MyApiProject.DtosLayer.CategoryDtos;
using MyApiProject.EntityLayer.Concrete;

namespace MyApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CetagoryList()
        {
            var values = _categoryService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDtos createCategoryDtos)
        {
            Category category = new Category();
            category.CategoryName = createCategoryDtos.CategoryName;
            category.Title = createCategoryDtos.Title;
            category.ImageUrl = createCategoryDtos.ImageUrl;
            _categoryService.TInsert(category);
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Silme Başarılı");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDtos updateCategoryDtos)
        {
            Category category = new Category();
            category.CategoryId = updateCategoryDtos.CategoryId;
            category.CategoryName = updateCategoryDtos.CategoryName;
            category.Title = updateCategoryDtos.Title;
            category.ImageUrl = updateCategoryDtos.ImageUrl;
            _categoryService.TUpdate(category);
            return Ok("Güncelleme Başarılı");
        }
    }
}
