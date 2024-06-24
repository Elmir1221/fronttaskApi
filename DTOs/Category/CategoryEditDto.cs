using System.ComponentModel.DataAnnotations;

namespace fronttaskApi.DTOs.Category
{
    public class CategoryEditDto
    {
        [Required]
        public string Name { get; set; }
    }
}
