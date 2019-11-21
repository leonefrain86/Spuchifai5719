using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuUpdateCancion : MenuListaCancion
    {
        public Cancion cancion { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            cancion = seleccionarElemento();
            Console.WriteLine();
            menuModificarCancion();
        }

        private void menuModificarCancion()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                cancion.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }
            if (preguntaCerrada("¿Cambiar número de orden?"))
            {
                cancion.NroOrden = Convert.ToByte(prompt("Ingrese el nuevo número de orden"));
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    ADOAdministrador.ADO.actualizarCancion(cancion);
                    Console.WriteLine("Canción actualizada con éxito");
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