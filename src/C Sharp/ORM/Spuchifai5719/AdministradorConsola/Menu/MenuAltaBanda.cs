using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;

namespace AdministradorConsola.Menu
{
    public class MenuAltaBanda : MenuComponente
    {
        public Banda banda { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre de la banda: ");
            var contrasenia = EncryptProvider.Sha256(ReadPassword("Ingrese la contraseña: "));
            banda = new Banda(nombre, contrasenia);
            try
            {
                ADOAdministrador.ADO.altaBanda(banda);
                Console.WriteLine("Banda agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
