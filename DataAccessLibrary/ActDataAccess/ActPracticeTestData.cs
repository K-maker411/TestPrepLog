using Dapper;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.ActDataAccess
{
    public class ActPracticeTestData : IActPracticeTestData
    {
        private readonly ISqlDataAccess _db;

        public ActPracticeTestData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ActPracticeTestModel>> GetActPracticeTest(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            string sql = "select * from dbo.actPracticeTest where id = @id";
            return _db.LoadData<ActPracticeTestModel, dynamic>(sql, parameters);
        }

        public Task<List<ActPracticeTestModel>> GetActPracticeTests()
        {
            string sql = "select * from dbo.actPracticeTest";

            return _db.LoadData<ActPracticeTestModel, dynamic>(sql, new { });
        }

        public Task InsertActPracticeTest(ActPracticeTestModel actPracticeTest)
        {
            string sql = @"insert into dbo.actPracticeTest (dateTaken, englishCorrect, mathCorrect, readingCorrect, scienceCorrect, testScore, dateAdministered) 
                           values (@dateTaken, @englishCorrect, @mathCorrect, @readingCorrect, @scienceCorrect, @testScore, @dateAdministered);";

            return _db.SaveData(sql, actPracticeTest);
        }

        public Task UpdateActPracticeTest(ActPracticeTestModel actPracticeTest)
        {
            string sql = @"update dbo.actPracticeTest set dateTaken = @dateTaken, englishCorrect = @englishCorrect, 
                           mathCorrect = @mathCorrect, readingCorrect = @readingCorrect,
                           scienceCorrect = @scienceCorrect, testScore = @testScore, 
                           dateAdministered = @dateAdministered where id = @id";

            return _db.SaveData(sql, actPracticeTest);
        }

        public Task DeleteActPracticeTest(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            string sql = "delete from dbo.actPracticeTest where id = @id";
            return _db.SaveData(sql, parameters);
        }
    }
}
