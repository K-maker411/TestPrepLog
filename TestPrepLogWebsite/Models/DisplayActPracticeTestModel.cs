using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPrepLogWebsite.Models
{
    public class DisplayActPracticeTestModel
    {
        [Required(ErrorMessage = "Please enter a valid date for date taken")]
        public DateTime? dateTaken { get; set; }
        [Required]
        [Range(0, 75, ErrorMessage = "Please enter a valid number for english correct")]
        public int englishCorrect { get; set; }
        [Required]
        [Range(0, 60, ErrorMessage = "Please enter a valid number for math correct")]
        public int mathCorrect { get; set; }
        [Required]
        [Range(0, 40, ErrorMessage = "Please enter a valid number for reading correct")]
        public int readingCorrect { get; set; }
        [Required]
        [Range(0, 40, ErrorMessage = "Please enter a valid number for science correct")]
        public int scienceCorrect { get; set; }
        [Required]
        [Range(1, 36, ErrorMessage = "Please enter a valid final score")]
        public int testScore { get; set; }
        [Required(ErrorMessage = "Please enter a valid date for date administered")]
        public DateTime? dateAdministered { get; set; }
    }
}
