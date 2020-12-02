using AutoMapper;
using MedicalExpress.API.Responses;
using MedicalExpress.CORE.DTOs;
using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MedicalExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _productservice = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productservice.GetProducts();
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            var response = new ApiResponse<IEnumerable<ProductDto>>(productDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productservice.GetProduct(id);
            var productDto = _mapper.Map<ProductDto>(product);

            var response = new ApiResponse<ProductDto>(productDto);
            return Ok(response);
        }


        [HttpGet]
        [Route("bycategory/{id}")]
        public async Task<IActionResult> GetProductbyCat(int id)
        {
            var products = await _productservice.GetProductbyCat(id);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            var response = new ApiResponse<IEnumerable<ProductDto>>(productDto);
            return Ok(response);
        }
        [HttpGet]
        [Route("byproduct/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var products = await _productservice.GetProductById(id);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            var response = new ApiResponse<IEnumerable<ProductDto>>(productDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductDto productDto)
        {

            var product = _mapper.Map<Product>(productDto);

            await _productservice.InsertProduct(product);
            productDto = _mapper.Map<ProductDto>(product);
            var response = new ApiResponse<ProductDto>(productDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.ProductoId = id;

            var result = await _productservice.UpdateProduct(product);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpPut]
        [Route("stockact")]
        public async Task<IActionResult> PutStock(int id, ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.ProductoId = id;

            var result = await _productservice.UpdateStock(product);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productservice.DeleteProduct(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }


    }
}
