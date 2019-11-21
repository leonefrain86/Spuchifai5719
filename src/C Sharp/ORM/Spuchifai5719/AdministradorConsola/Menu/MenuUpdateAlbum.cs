using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuUpdateAlbum : MenuListaAlbum
    {
        public Album album { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            album = seleccionarElemento();
            Console.WriteLine();
            menuModificarAlbum();
        }

        private void menuModificarAlbum()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                album.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    ADOAdministrador.ADO.actualizarAlbum(album);
                    Console.WriteLine("Álbum actualizado con éxito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}