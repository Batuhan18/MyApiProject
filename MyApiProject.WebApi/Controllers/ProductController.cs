using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.BusinessLayer.Abstract;
using MyApiProject.DtosLayer.ProductDtos;
using MyApiProject.EntityLayer.Concrete;

namespace MyApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDtos createProductDtos)
        {
            Product product = new Product();
            product.ProductName = createProductDtos.ProductName;
            product.Price = createProductDtos.Price;
            product.Detail = createProductDtos.Detail;
            product.ImageUrl = createProductDtos.ImageUrl;
            product.CategoryId = createProductDtos.CategoryId;
            _productService.TInsert(product);
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return Ok("Silme Başarılı");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDtos updateProductDtos)
        {
            Product product = new Product();
            product.ProductId = updateProductDtos.ProductId;
            product.ProductName = updateProductDtos.ProductName;
            product.Price = updateProductDtos.Price;
            product.Detail = updateProductDtos.Detail;
            product.ImageUrl = updateProductDtos.ImageUrl;
            product.CategoryId = updateProductDtos.CategoryId;
            _productService.TUpdate(product);
            return Ok("Güncelleme Başarılı");
        }
    }
}
