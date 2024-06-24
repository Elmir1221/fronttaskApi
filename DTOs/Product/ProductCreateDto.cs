using System.ComponentModel.DataAnnotations;

namespace fronttaskApi.DTOs.ProductDtos
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public List<IFormFile> UploadImages { get; set; }
    }
}
