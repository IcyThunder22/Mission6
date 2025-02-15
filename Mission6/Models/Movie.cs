using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieID {  get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Category { get; set; } 
        [Required]
        public int Year { get; set; }
        [Required]
        public required string Director { get; set; } 
        [Required]
        public required string Rating { get; set; } 
        
        public bool? Edited { get; set; }

        public string? LentTo { get; set; }
        public string? Notes { get; set; }

    }
}
