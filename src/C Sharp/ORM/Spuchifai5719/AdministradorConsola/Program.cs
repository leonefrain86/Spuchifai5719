using System;
using AdministradorConsola.Menu;
using MenuesConsola;

namespace AdministradorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaBanda = new MenuAltaBanda() { Nombre = "Agregar Banda" };
            var menuModificarBanda = new MenuUpdateBanda() { Nombre = "Actualizar Banda" };
            var menuListaBanda = new MenuListaBanda() { Nombre = "Listado de Bandas" };

            var menuModificarAlbum = new MenuUpdateAlbum() { Nombre = "Actualizar Album" };
            var menuListaAlbum = new MenuListaAlbum() { Nombre = "Listado de Álbumes" };

            var menuModificarCancion = new MenuUpdateCancion() { Nombre = "Actualizar Canciones" };
            var menuListaCancion = new MenuListaCancion() { Nombre = "Listado de Canciones" };

            var menuListaCliente = new MenuListaCliente() { Nombre = "Listado de Clientes" };

            var menuBanda = new MenuCompuesto() { Nombre = "Bandas" };
            menuBanda.agregarMenu(menuModificarBanda);
            menuBanda.agregarMenu(menuListaBanda);
            menuBanda.agregarMenu(menuAltaBanda);

            var menuAlbum = new MenuCompuesto() { Nombre = "Álbumes" };
            menuAlbum.agregarMenu(menuModificarAlbum);
            menuAlbum.agregarMenu(menuListaAlbum);

            var menuCancion = new MenuCompuesto() { Nombre = "Canciones" };
            menuCancion.agregarMenu(menuModificarCancion);
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
