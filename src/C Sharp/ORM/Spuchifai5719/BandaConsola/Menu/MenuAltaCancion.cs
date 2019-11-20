using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using BandaConsola.Menu;

namespace BandaConsola.Menu
{
    public class MenuAltaCancion : MenuComponente
    {
        private MenuListaAlbumes MenuListaAlbumes { get; set; }
        private Cancion Cancion { get; set; }
        
        public MenuAltaCancion(MenuListaAlbumes menuListaAlbumes)
        {
            MenuListaAlbumes = menuListaAlbumes;
            Nombre = "Alta Cancion";
        }

        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre de la cancion");
            var nroOrden = prompt("Ingrese nro de orden de la cancion");
            Console.WriteLine("Seleccione un album: ");
            var album = MenuListaAlbumes.seleccionarElemento();

            Cancion = new Cancion(nombre, nroOrden, album)

            try
            {
                AdoBanda.ADO.altaCancion(Cancion);
                Console.WriteLine("Cancion dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta la cancion: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}