using AutoMapper;
using fronttaskApi.DTOs.ProductDtos;
using fronttaskApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fronttaskApi.Controllers.Admin
{
    
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,
            IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<ProductMainImageDto>>(await _productService.GetAllWithImagesAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            var product = await _productService.GetByIdWithAllDatasAsync(id);

            if (product is null) return NotFound();

            return Ok(_mapper.Map<ProductDetailDto>(product));
        }
    }
}
