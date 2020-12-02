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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _categoryservice = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryservice.GetCategories();
            var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            var response = new ApiResponse<IEnumerable<CategoryDto>>(categoriesDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var categorie = await _categoryservice.GetCategory(id);
            var categorieDto = _mapper.Map<CategoryDto>(categorie);

            var response = new ApiResponse<CategoryDto>(categorieDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryDto categoryDto)
        {

            var category = _mapper.Map<Category>(categoryDto);

            await _categoryservice.InsertCategory(category);
            categoryDto = _mapper.Map<CategoryDto>(category);
            var response = new ApiResponse<CategoryDto>(categoryDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            category.CategoryId = id;

            var result = await _categoryservice.UpdateCategory(category);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _categoryservice.DeleteCategory(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
