using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;

namespace BandaConsola.Menu
{
    public class CrearAlbum : MenuComponente
    {
        public Album album { get; set; }
        public Banda banda { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre album: ");
            var banda = new Banda("LEONJ", "SMAMSLAM");
            album = new Album(nombre,banda);
            try
            {
                AdoBanda.ADO.agregarCategoria(album);
                Console.WriteLine("Categoria agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
