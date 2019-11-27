using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Spuchifai5719;
using NETCore.Encrypt;
using static System.ReadLine;

namespace AdministradorConsola.Menu
{
    public class MenuAltaBanda : MenuComponente
    {
        private Banda Banda { get; set; }

        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del album: ");
            var pass = ReadPassword("Ingrese contraseñia de la Banda: ");
            pass = EncryptProvider.Sha256(pass);
            Banda = new Banda(nombre, pass);

            try
            {
                ADOAdministrador.ADO.altaBanda(Banda);
                Console.WriteLine("Banda dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el album: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
