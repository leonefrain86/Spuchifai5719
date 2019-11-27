using System;
using ClienteConsola.Menu;
using MenuesConsola;

namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuInicioSesion = new MenuInicioSesion() { Nombre = "Login" };
            var menuRegistro = new MenuAltaCliente() { Nombre = "Sing in" };

            var menuPrincipal = new MenuCompuesto() { Nombre = "Clente" };
            menuPrincipal.agregarMenu(menuInicioSesion);
            menuPrincipal.agregarMenu(menuRegistro);
        
            menuPrincipal.mostrar();
            
        }
    }
}
