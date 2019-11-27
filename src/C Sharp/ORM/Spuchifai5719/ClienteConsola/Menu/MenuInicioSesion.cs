using MenuesConsola;
using NETCore.Encrypt;
using Spuchifai5719;
using System;
using static System.ReadLine;

namespace ClienteConsola.Menu
{
    public class MenuInicioSesion : MenuComponente
    {
        private Cliente Cliente { get; set; }
        private MenuCompuesto PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var mail = prompt("Ingrese mail");
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                Cliente = ADOCliente.ADO.clientePorUserYPass(mail, pass);
                if (Cliente is null)
                {
                    Console.WriteLine("mail o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {
                    instanciarMenuesPara(Cliente);
                    PrincipalUsuario.mostrar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {e.Message}");
                Console.ReadKey();
            }
        }

        private void instanciarMenuesPara(Cliente cliente)
        {
            var menuListaBanda = new MenuListaBanda() { Nombre = "Listado de Bandas" };

            var menuListaAlbum = new MenuListaAlbum() { Nombre = "Listado de Álbumes" };

            var menuListaCancion = new MenuListaCancion() { Nombre = "Listado de Canciones" };

            var menuListaReproduccion = new MenuListaReproduccion() { Nombre = "Listado de Reproducciones" , cliente = Cliente};
            var menuAltaReproduccion = new MenuAltaReproduccion(menuListaCancion) { Nombre = "Alta Reproduccion", cliente = Cliente };

            var menuReproduccion = new MenuCompuesto() { Nombre = "Escuchar Canción" };
            menuReproduccion.agregarMenu(menuListaReproduccion);
            menuReproduccion.agregarMenu(menuAltaReproduccion);

            PrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Cajero" };
            PrincipalUsuario.agregarMenu(menuListaBanda);
            PrincipalUsuario.agregarMenu(menuListaAlbum);
            PrincipalUsuario.agregarMenu(menuListaCancion);
            PrincipalUsuario.agregarMenu(menuReproduccion);
        }
    }
}
