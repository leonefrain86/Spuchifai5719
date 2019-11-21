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
        public Cliente cliente { get; set; }
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
            try
            {
                cliente.ReproducirCancion(cancion);
                ADOCliente.ADO.actualizarCliente(cliente);
                Console.WriteLine("Canción escuchada con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la reproducción por: {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
