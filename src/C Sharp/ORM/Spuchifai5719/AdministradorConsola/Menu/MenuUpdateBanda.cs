using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;

namespace AdministradorConsola.Menu
{
    public class MenuUpdateBanda : MenuListaBanda
    {
        public Banda banda { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            banda = seleccionarElemento();
            Console.WriteLine();
            menuModificarBanda();
        }

        private void menuModificarBanda()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                banda.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }
            if (preguntaCerrada("¿Cambiar contraseña?"))
            {
                banda.Password = prompt("Ingrese la nueva contraseña");
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    ADOAdministrador.ADO.actualizarBanda(banda);
                    Console.WriteLine("Banda actualizada con éxito");
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
