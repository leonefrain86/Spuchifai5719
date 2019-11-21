using System;
using AdministradorConsola.Menu;
using MenuesConsola;

namespace AdministradorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaBanda = new MenuAltaBanda() { Nombre = "Alta Banda" };
            var menuListaBanda = new MenuListaBanda() { Nombre = "Listado de Bandas" };

            var menuAltaAlbum = new MenuAltaAlbum(menuListaBanda) { Nombre = "Alta Album" };
            var menuListaAlbum = new MenuListaAlbum() { Nombre = "Listado de Álbumes" };

            var menuAltaCancion = new MenuAltaCancion(menuListaAlbum, menuListaBanda) { Nombre = "Alta Canciones" };
            var menuListaCancion = new MenuListaCancion() { Nombre = "Listado de Canciones" };

            var menuListaCliente = new MenuListaCliente() { Nombre = "Listado de Clientes" };

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
           

            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuPrincipal.agregarMenu(menuBanda);
            menuPrincipal.agregarMenu(menuAlbum);
            menuPrincipal.agregarMenu(menuCancion);
            menuPrincipal.agregarMenu(menuCliente);

            menuPrincipal.mostrar();

        }
    }
}
