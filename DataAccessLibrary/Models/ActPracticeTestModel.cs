using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ActPracticeTestModel
    {
        public int id { get; set; }
        public DateTime? dateTaken { get; set; }
        public int englishCorrect { get; set; }
        public int mathCorrect { get; set; }
        public int readingCorrect { get; set; }
        public int scienceCorrect { get; set; }
        public int testScore { get; set; }
        public DateTime? dateAdministered { get; set; }
    }
}
