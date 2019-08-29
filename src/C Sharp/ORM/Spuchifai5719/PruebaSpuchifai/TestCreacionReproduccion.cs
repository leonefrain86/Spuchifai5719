using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spuchifai5719;
using Spuchifai5719.ADO;
using System.Collections.Generic;

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
        }

        [TestMethod]
        public void CrearReproduccionDosClientes()
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

            Cliente unCliente1 = new Cliente("Ana", "Rodrigez", "anarodrigues@gmail.com", "truytu");
            Cliente unCliente2 = new Cliente("Roberto", "Cuevas", "robertocuevas@gmail.com", "ejhguguf");
            ado.altaCliente(unCliente2);
            ado.altaCliente(unCliente1);
            unCliente1.ReproducirCancion(unaCancion);
            unCliente2.ReproducirCancion(unaCancion);
            unCliente1.ReproducirCancion(unaCancion);
            ado.actualizarCliente(unCliente1);
            ado.actualizarCliente(unCliente2);

            int res = unaCancion.CantidadReproducciones();
            Assert.AreEqual(3, res);

        }
        
        [TestMethod]
        public void Verificacion_de_Cliente()
        {
            var ado = new MYSQLADO();
            var res2 = ado.clientePorUserYPass("narodrigues@gmail.com", "truytu");

            Assert.AreEqual(null, res2);
        }

        [TestMethod]
        public void TestTraerCanciones()
        {
            var ado = new MYSQLADO();

            Banda unaBanda = new Banda("XR");
            ado.altaBanda(unaBanda);

            Album unAlbum = new Album("AR", unaBanda);
            ado.altaAlbum(unAlbum);

            Cancion unaCancion = new Cancion("R", 9, unAlbum);
            ado.altaCancion(unaCancion);

            List<Cancion> res = ado.traerCanciones();

            int cantidadCanciones = res.Count;
            
            Assert.AreEqual(2, cantidadCanciones);

        }
    }
}
