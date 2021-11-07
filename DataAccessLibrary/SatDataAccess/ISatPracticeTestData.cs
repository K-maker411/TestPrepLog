using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISatPracticeTestData
    {
        Task<List<SatPracticeTestModel>> GetSatPracticeTest(int id);
        Task<List<SatPracticeTestModel>> GetSatPracticeTests();
        Task InsertSatPracticeTest(SatPracticeTestModel satPracticeTest);
        Task UpdateSatPracticeTest(SatPracticeTestModel satPracticeTest);
        Task DeleteSatPracticeTest(int id);
    }
}