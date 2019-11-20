using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace BandaConsola.Menu
{
    public class MenuAltaAlbum : MenuComponente
    {
        private MenuListaBandas MenuListaBandas { get; set; }
        private Album Album { get; set; }
        
        public MenuAltaAlbum(MenuListaBandas menuListaBandas)
        {
            MenuListaBandas = menuListaBandas;
            Nombre = "Alta Album";
        }

        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del album");
            Console.WriteLine("Seleccione una banda: ");
            var banda = MenuListaBandas.seleccionarElemento();

            Album = new Album(nombre, banda)

            try
            {
                AdoBanda.ADO.altaAlbum(Album);
                Console.WriteLine("Album dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el album: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}