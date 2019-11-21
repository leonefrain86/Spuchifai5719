using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuAltaAlbum : MenuComponente
    {
        private MenuListaBanda menuListaBanda { get; set; }
        public Album album { get; set; }
        public MenuAltaAlbum(MenuListaBanda MenuListaBanda)
        {
            menuListaBanda = MenuListaBanda;
            Nombre = "Alta Producto";
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del álbum: ");
            Console.WriteLine("Seleccione la banda x)");
            var banda = menuListaBanda.seleccionarElemento();
            album = new Album(nombre, banda);
            try
            {
                ADOAdministrador.ADO.altaAlbum(album);
                Console.WriteLine("Álbum agregado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}