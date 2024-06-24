using AutoMapper;
using fronttaskApi.DTOs.Category;
using fronttaskApi.DTOs.ProductDtos;
using fronttaskApi.Services;
using fronttaskApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fronttaskApi.Controllers.Admin
{
    
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(
            ICategoryService categoryService,
            IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(await _categoryService.GetAllAsync()));
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CategoryCreateDto data)
        {
            await _categoryService.CreateAsync(data);
            return CreatedAtAction(nameof(Create), data);

        }

    }
}
