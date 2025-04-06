using System.ComponentModel.DataAnnotations;

namespace RealEstateApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name can't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Image url can't be empty")]
        public string ImageUrl { get; set; }
    }
}
