using Dapper;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SatPracticeTestData : ISatPracticeTestData
    {
        private readonly ISqlDataAccess _db;

        public SatPracticeTestData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SatPracticeTestModel>> GetSatPracticeTest(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            string sql = "select * from dbo.satPracticeTest where id = @id";
            return _db.LoadData<SatPracticeTestModel, dynamic>(sql, parameters);
        }

        public Task<List<SatPracticeTestModel>> GetSatPracticeTests()
        {
            string sql = "select * from dbo.satPracticeTest";

            return _db.LoadData<SatPracticeTestModel, dynamic>(sql, new { });
        }

        public Task InsertSatPracticeTest(SatPracticeTestModel satPracticeTest)
        {
            string sql = @"insert into dbo.satPracticeTest (dateTaken, readingCorrect, writingCorrect, mathNonCalcCorrect, mathCalcCorrect, testScore, dateAdministered, frontPageImage, backPageImage, frontPageImageUrl, backPageImageUrl) 
                           values (@dateTaken, @readingCorrect, @writingCorrect, @mathNonCalcCorrect, @mathCalcCorrect, @testScore, @dateAdministered, @frontPageImage, @backPageImage, @frontPageImageUrl, @backPageImageUrl);";

            return _db.SaveData(sql, satPracticeTest);
        }

        public Task UpdateSatPracticeTest(SatPracticeTestModel satPracticeTest)
        {
            string sql = @"update dbo.satPracticeTest set dateTaken = @dateTaken, readingCorrect = @readingCorrect, 
                           writingCorrect = @writingCorrect, mathNonCalcCorrect = @mathNonCalcCorrect,
                           mathCalcCorrect = @mathCalcCorrect, testScore = @testScore, 
                           dateAdministered = @dateAdministered, frontPageImage = @frontPageImage,
                           backPageImage = @backPageImage, frontPageImageUrl = @frontPageImageUrl,
                           backPageImageUrl = @backPageImageUrl
                           where id = @id";

            return _db.SaveData(sql, satPracticeTest);
        }

        public Task DeleteSatPracticeTest(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            string sql = "delete from dbo.satPracticeTest where id = @id";
            return _db.SaveData(sql, parameters);
        }
    }
}
