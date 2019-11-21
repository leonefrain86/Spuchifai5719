using System;
using AdministradorConsola.Menu;
using MenuesConsola;

namespace AdministradorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaBanda = new MenuUpdateBanda() { Nombre = "Actualizar Banda" };
            var menuListaBanda = new MenuListaBanda() { Nombre = "Listado de Bandas" };

            var menuAltaAlbum = new MenuUpdateAlbum() { Nombre = "Actualizar Album" };
            var menuListaAlbum = new MenuListaAlbum() { Nombre = "Listado de Álbumes" };

            var menuAltaCancion = new MenuUpdateCancion() { Nombre = "Actualizar Canciones" };
            var menuListaCancion = new MenuListaCancion() { Nombre = "Listado de Canciones" };

            var menuListaCliente = new MenuListaCliente() { Nombre = "Listado de Clientes" };
            var menuAltaCliente = new MenuUpdateCliente() { Nombre = "Alta Cliente" };

            var menuBanda = new MenuCompuesto() { Nombre = "Bandas" };
            menuBanda.agregarMenu(menuAltaBanda);
            menuBanda.agregarMenu(menuListaBanda);

            var menuAlbum = new MenuCompuesto() { Nombre = "Álbumes" };
            menuAlbum.agregarMenu(menuAltaAlbum);
            menuAlbum.agregarMenu(menuListaAlbum);

            var menuCancion = new MenuCompuesto() { Nombre = "Canciones" };
            menuCancion.agregarMenu(menuAltaCancion);
            menuCancion.agregarMenu(menuListaCancion);

            var menuCliente = new MenuCompuesto() { Nombre = "Clientes" };
            menuCliente.agregarMenu(menuListaCliente);
            menuCliente.agregarMenu(menuAltaCliente);


            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuPrincipal.agregarMenu(menuBanda);
            menuPrincipal.agregarMenu(menuAlbum);
            menuPrincipal.agregarMenu(menuCancion);
            menuPrincipal.agregarMenu(menuCliente);

            menuPrincipal.mostrar();

        }
    }
}
