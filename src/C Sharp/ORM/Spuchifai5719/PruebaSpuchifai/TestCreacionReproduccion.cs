using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spuchifai5719;
using Spuchifai5719.ADO;

namespace PruebaSpuchifai
{
    [TestClass]
    public class TestCreacionReproduccion
    {
        [TestMethod]
        public void CreacionDeReproduccion()
        {
            var ado = new MYSQLADO();

            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Banda unaBanda = new Banda("RXR");
            ado.altaBanda(unaBanda);

            Album unAlbum = new Album("RAR", unaBanda);
            ado.altaAlbum(unAlbum);


            Cancion unaCancion = new Cancion("D4C", 8, unAlbum);
            ado.altaCancion(unaCancion);

            Cliente unCliente = new Cliente("Ana", "Rodrigez", "anarodrigues@gmail.com", "truytu");
            unCliente.ReproducirCancion(unaCancion);
            ado.altaCliente(unCliente);

            int res = unaBanda.CantidadDeReproduccionesPorBanda();
            Assert.AreEqual(1, res);

            var res2 = ado.clientePorUserYPass("anarodrigues@gmail.com", "truytu");

            Assert.AreEqual(null, res2);
        }

        //[TestMethod]
        //public void CantidadDeReproducciones()
        //{
        //    Banda banda = new Banda();

        //    int res = banda.CantidadDeReproduccionesPorBanda();
        //    Assert.AreEqual(0, res);
        //}
    }
}
