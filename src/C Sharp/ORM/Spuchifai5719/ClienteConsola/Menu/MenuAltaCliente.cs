using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using ClienteConsola.Menu;

namespace ClienteConsola.Menu
{
    public class MenuAltaCliente : MenuComponente
    {
        private Cliente cliente { get; set; }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del cliente");
            var apellido = prompt("Ingrese apellido del cliente");
            var mail = prompt("Ingrese mail del cliente");
            var contrasenia = EncryptProvider.Sha256(ReadPassword("Ingrese la contraseña del cliente: "));

            cliente = new Cliente(nombre, apellido, mail, contrasenia);
       
            try
            {
                ADOCliente.ADO.altaCliente(cliente);
                Console.WriteLine("Cliente registrado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la informacion por: {e.InnerException.Message}");
            }
            Console.ReadKey();

        }
    }
}
