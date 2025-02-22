using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID {  get; set; }

        [Required]
        public string Title { get; set; }

        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set; } 
        public Category? Category { get; set; }
        
        [Required]
        public int Year { get; set; }
        
        public string? Director { get; set; } 
        
        public string? Rating { get; set; }
        
        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }
        
        public string? Notes { get; set; }

    }
}
