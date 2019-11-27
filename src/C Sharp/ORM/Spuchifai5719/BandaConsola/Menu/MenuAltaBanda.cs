using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Spuchifai5719;
using NETCore.Encrypt;
using static System.ReadLine;

namespace BandaConsola.Menu
{
    public class MenuAltaBanda : MenuComponente
    {
        private Banda Banda { get; set; }

        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del banda: ");
            var pass = ReadPassword("Ingrese contraseña de la Banda: ");
            pass = EncryptProvider.Sha256(pass);
            Banda = new Banda(nombre, pass);

            try
            {
                AdoBanda.ADO.altaBanda(Banda);
                Console.WriteLine("Banda registrada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta la banda: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
