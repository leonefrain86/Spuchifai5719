using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuAltaCliente : MenuComponente
    {
        public Cliente cliente { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del cliente");
            var apellido = prompt("Ingrese apellido del cliente");
            var mail = prompt("Ingrese mail del cliente");
            var contrasenia = EncryptProvider.Sha256(ReadPassword("Ingrese la contraseña: "));
            cliente = new Cliente(nombre, apellido, mail, contrasenia);
            try
            {
                ADOAdministrador.ADO.altaCliente(cliente);
                Console.WriteLine("Cliente agregado con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar al cliente por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
