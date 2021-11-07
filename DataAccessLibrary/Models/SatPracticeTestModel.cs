using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class SatPracticeTestModel
    {
        public int id { get; set; }
        public DateTime? dateTaken { get; set; }
        public int readingCorrect { get; set; }
        public int writingCorrect { get; set; }
        public int mathNonCalcCorrect { get; set; }
        public int mathCalcCorrect { get; set; }
        public int testScore { get; set; }
        public DateTime? dateAdministered { get; set; }
        public byte[] frontPageImage { get; set; }
        public byte[] backPageImage { get; set; }
        public string frontPageImageUrl { get; set; }
        public string backPageImageUrl { get; set; }
    }
}
