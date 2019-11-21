using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuAltaCancion : MenuComponente
    {
        private MenuListaAlbum menuListaAlbum { get; set; }
        private MenuListaBanda menuListaBanda { get; set; }
        public Cancion cancion { get; set; }
        public MenuAltaCancion(MenuListaAlbum MenuListaAlbum, MenuListaBanda MenuListaBanda)
        {
            menuListaAlbum = MenuListaAlbum;
            menuListaBanda = MenuListaBanda;
            Nombre = "Alta Producto";
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre de la canción: ");
            Console.Write("Ingrese el número de orden: ");
            var nroOrden = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Seleccione el álbum x)");
            var album = menuListaAlbum.seleccionarElemento();
            cancion = new Cancion(nombre, nroOrden, album);
            try
            {
                ADOAdministrador.ADO.altaCancion(cancion);
                Console.WriteLine("Canción agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}