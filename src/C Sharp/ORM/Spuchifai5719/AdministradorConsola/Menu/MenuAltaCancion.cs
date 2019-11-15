using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;

namespace AdministradorConsola
{
    public class MenuAltaCancion : MenuComponente
    {
        private MenuListaAlbum MenuListaAlbum { get; set; }
        public Cancion cancion { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del álbum: ");
            Console.Write("Ingrese el número de orden: ");
            var nroOrden = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Seleccione una categoria x)");
            var album = MenuListaAlbum.seleccionarElemento();
            cancion = new Cancion(nombre, nroOrden, album);
            try
            {
                ADOAdministrador.ADO.altaCancion(cancion);
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