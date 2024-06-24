using System.ComponentModel.DataAnnotations;

namespace fronttaskApi.DTOs.Category
{
    public class CategoryCreateDto
    {
        [Required]
        public string name { get; set; }
    }
}
