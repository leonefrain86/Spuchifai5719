using System;
using BandaConsola.Menu;
using MenuesConsola;

namespace BandaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuInicioSesionBanda = new MenuInicioSesionBanda() { Nombre = "Login Banda" };

            menuInicioSesionBanda.mostrar(); 
        }
    }
}
