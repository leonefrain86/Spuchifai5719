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

                menuInicioSesion.mostrar();
            
        }
    }
}
