using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int? CategoryID {  get; set; }
        [Required]
        public string? CategoryName { get; set; }
        

    }
}
