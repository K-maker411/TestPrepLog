using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.ActDataAccess
{
    public interface IActPracticeTestData
    {
        Task DeleteActPracticeTest(int id);
        Task<List<ActPracticeTestModel>> GetActPracticeTest(int id);
        Task<List<ActPracticeTestModel>> GetActPracticeTests();
        Task InsertActPracticeTest(ActPracticeTestModel actPracticeTest);
        Task UpdateActPracticeTest(ActPracticeTestModel actPracticeTest);
    }
}