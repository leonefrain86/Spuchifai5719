using System;
using BandaConsola.Menu;
using MenuesConsola;

namespace BandaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuInicioSesionBanda = new MenuInicioSesionBanda() { Nombre = "Login" };
            var menuRegistroBanda = new MenuAltaBanda () { Nombre = "Sing in" };

            var menuPrincipal = new MenuCompuesto() { Nombre = "Banda" };
            menuPrincipal.agregarMenu(menuInicioSesionBanda);
            menuPrincipal.agregarMenu(menuRegistroBanda);

            menuPrincipal.mostrar();
        }
    }
}
