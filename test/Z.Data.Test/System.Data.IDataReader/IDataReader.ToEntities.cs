using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ToEntities
    {
        [TestMethod]
        public void ToEntity()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn UNION SELECT 2, 'BuzzBuzz'";

            IEnumerable<TestObject> result;

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        result = reader.ToEntities<TestObject>();
                    }
                }
            }

            // Unit Test
            List<TestObject> list = result.ToList();

            Assert.AreEqual(1, list[0].IntColumn);
            Assert.AreEqual("FizzBuzz", list[0].StringColumn);
            Assert.AreEqual(2, list[1].IntColumn);
            Assert.AreEqual("BuzzBuzz", list[1].StringColumn);
            Assert.AreEqual(-1, list[0].IntColumnNotExists);
        }

        public class TestObject
        {
            public int IntColumn;
            public int IntColumnNotExists = -1;
            public string StringColumnNotExists;
            public string StringColumn { get; set; }
        }
    }
}