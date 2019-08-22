using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spuchifai5719;
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

        [TestMethod]
        public void ReproducirCancion()
        {
            var ado = new MYSQLADO();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Cliente unCliente = new Cliente("Ana", "Rodrigez", " anarodrigues@gmail.com", "truytu");
            ado.altaCliente(unCliente);

            Cancion unaCancion = new Cancion("lalala", 8);
            ado.altaCancion(unaCancion);

            //unCliente.ReproducirCancion(unaCancion);

        }

    }
}
