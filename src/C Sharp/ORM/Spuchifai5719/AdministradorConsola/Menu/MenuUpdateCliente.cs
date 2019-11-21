using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using AdministradorConsola.Menu;

namespace AdministradorConsola
{
    public class MenuUpdateCliente : MenuComponente
    {
        public Cliente cliente { get; set; }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del cliente");
            var apellido = prompt("Ingrese apellido del cliente");
            var mail = prompt("Ingrese mail del cliente");
            var contrasenia = EncryptProvider.Sha256(ReadPassword("Ingrese la contraseña del cliente"));


            cliente = new Cliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                Mail = mail,
                Password = contrasenia
            };
            try
            {
                ADOAdministrador.ADO.altaCliente(cliente);
                Console.WriteLine("Cliente creado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la reproducción por: {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
