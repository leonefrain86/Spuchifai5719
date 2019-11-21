using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using ClienteConsola.Menu;

namespace ClienteConsola.Menu
{
    public class MenuAltaReproduccion : MenuComponente
    {
        private MenuListaCancion menuListaCancion { get; set; }
        public Reproduccion reproduccion { get; set; }
        public MenuAltaReproduccion(MenuListaCancion MenuListaCancion)
        {
            menuListaCancion = MenuListaCancion;
            Nombre = "Alta Reproduccion";
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            Console.WriteLine("Seleccione la canción a escuchar x)");
            var cancion = menuListaCancion.seleccionarElemento();
            reproduccion = new Reproduccion() { cancion = cancion };
            try
            {
                ADOCliente.ADO.altaReproduccion(reproduccion);
                Console.WriteLine("Canción escuchada con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
