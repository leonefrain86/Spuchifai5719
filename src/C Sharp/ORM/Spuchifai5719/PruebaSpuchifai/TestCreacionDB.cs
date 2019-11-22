using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spuchifai5719.ADO;

namespace PruebaSpuchifai
{
    [TestClass]
    public class TestCreacionDB
    {
        public static MYSQLADO AdoMySQL { get; set; }

        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {
            AdoMySQL = new MYSQLADO();
            AdoMySQL.Database.EnsureDeleted();
        }

        [TestMethod]
        public void SeCreaDB()
        {
            AdoMySQL.Database.EnsureCreated();
        }
    }
}
