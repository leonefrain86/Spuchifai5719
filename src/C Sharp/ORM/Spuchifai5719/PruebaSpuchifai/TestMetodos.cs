using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spuchifai5719;
using Spuchifai5719.ADO;
using System.Collections.Generic;

namespace PruebaSpuchifai
{
    [TestClass]
    public class TestMetodos
    {
        [TestMethod]
        public void Creacion_de_la_tabla_Reproduccion_con_un_cliente()
        {
            var ado = new MYSQLADO();

            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Banda unaBanda = new Banda("RXR", "12345");
            ado.altaBanda(unaBanda);

            Album unAlbum = new Album("RAR", unaBanda);
            ado.altaAlbum(unAlbum);

            Cancion unaCancion = new Cancion("D4C", 8, unAlbum);
            ado.altaCancion(unaCancion);

            Cliente unCliente = new Cliente("Ana", "Rodrigez", "anarodrigues@gmail.com", "truytu");

            unCliente.ReproducirCancion(unaCancion);
            ado.altaCliente(unCliente);     
        }

        [TestMethod]
        public void Test_de_cantidad_de_reproducciones_por_Banda_asegurando_que_hay_2()
        {
            var ado = new MYSQLADO();

            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Banda unaBanda = new Banda("TXT", "12345");
            ado.altaBanda(unaBanda);

            Album unAlbum = new Album("ROR", unaBanda);
            ado.altaAlbum(unAlbum);

            Cancion unaCancion = new Cancion("D3C", 8, unAlbum);
            ado.altaCancion(unaCancion);

            Cancion otraCancion = new Cancion("WRE", 9, unAlbum);

            Cliente unCliente = new Cliente("Anuel", "Rodrigez", "anarodrigues@gmail.com", "ryuu");

            unCliente.ReproducirCancion(unaCancion);
            unCliente.ReproducirCancion(otraCancion);
            ado.altaCliente(unCliente);

            int res = unaBanda.CantidadDeReproduccionesPorBanda();
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Creacion_de_la_tabla_Reproduccion_con_mas_de_un_cliente()
        {
            var ado = new MYSQLADO();

            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Banda unaBanda = new Banda("RXR", "12345");
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
        public void Test_Verificacion_de_Cliente_por_gmail_y_password()
        {
            var ado = new MYSQLADO();
            var res2 = ado.clientePorUserYPass("narodrigues@gmail.com", "truytu");

            Assert.AreEqual(null, res2);
        }

        [TestMethod]
        public void Test_de_Traer_la_lista_de_Canciones()
        {
            var ado = new MYSQLADO();

            Banda unaBanda = new Banda("XR", "12345");
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
