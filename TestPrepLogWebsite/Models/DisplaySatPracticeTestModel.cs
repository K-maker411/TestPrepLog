using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPrepLogWebsite.Models
{
    public class DisplaySatPracticeTestModel
    {
        [Required(ErrorMessage = "Please enter a valid date for date taken")]
        public DateTime? dateTaken { get; set; }
        [Required]
        [Range(0, 52, ErrorMessage = "Please enter a valid number for reading correct")]
        public int readingCorrect { get; set; }
        [Required]
        [Range(0, 44, ErrorMessage = "Please enter a valid number for writing correct")]
        public int writingCorrect { get; set; }
        [Required]
        [Range(0, 20, ErrorMessage = "Please enter a valid number for math (non-calc) correct")]
        public int mathNonCalcCorrect { get; set; }
        [Required]
        [Range(0, 38, ErrorMessage = "Please enter a valid number for math (calc) correct")]
        public int mathCalcCorrect { get; set; }
        [Required]
        [Range(400, 1600, ErrorMessage = "Please enter a valid final score")]
        public int testScore { get; set; }
        [Required(ErrorMessage = "Please enter a valid date for date administered")]
        public DateTime? dateAdministered { get; set; }
        public byte[] frontPageImage { get; set; }
        public byte[] backPageImage { get; set; }
        public string frontPageImageUrl { get; set; }
        public string backPageImageUrl { get; set; }
    }
}
