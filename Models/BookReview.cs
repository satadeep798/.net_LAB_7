using System.ComponentModel.DataAnnotations;

namespace Lab_7.Models
{
    public class BookReview
    {
        [Required(ErrorMessage = "Reviewer name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be 2 to 50 characters")]
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        [Required(ErrorMessage = "Book title is required")]
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "Please choose a genre")]
        public string Genre { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Review text is required")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Review must be 10 to 300 characters")]
        [Display(Name = "Your Review")]
        public string ReviewText { get; set; }
    }
}
