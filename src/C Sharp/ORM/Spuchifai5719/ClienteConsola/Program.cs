using System;
using ClienteConsola.Menu;
using MenuesConsola;

namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            if ()
            {
                var menuListaBanda = new MenuListaBanda() { Nombre = "Listado de Bandas" };

                var menuListaAlbum = new MenuListaAlbum() { Nombre = "Listado de Álbumes" };

                var menuListaCancion = new MenuListaCancion() { Nombre = "Listado de Canciones" };

                var menuListaReproduccion = new MenuListaReproduccion() { Nombre = "Listado de Reproducciones" };
                var menuAltaReproduccion = new MenuAltaReproduccion(menuListaCancion) { Nombre = "Alta Reproduccion" };

                var menuReproduccion = new MenuCompuesto() { Nombre = "Canciones" };
                menuReproduccion.agregarMenu(menuAltaReproduccion);
                menuReproduccion.agregarMenu(menuListaReproduccion);

                var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Administrador" };
                menuPrincipal.agregarMenu(menuListaBanda);
                menuPrincipal.agregarMenu(menuListaAlbum);
                menuPrincipal.agregarMenu(menuListaCancion);
                menuPrincipal.agregarMenu(menuReproduccion);


                menuPrincipal.mostrar();
            }
            else
            {
                Console.WriteLine("No se ingresó correctamente el usuario");
            }
        }
    }
}
