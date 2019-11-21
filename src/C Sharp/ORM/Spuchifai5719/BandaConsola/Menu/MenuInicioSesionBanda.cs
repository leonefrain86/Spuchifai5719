using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;
using static System.ReadLine;
using NETCore.Encrypt;
using BandaConsola;

namespace BandaConsola.Menu
{
    public class MenuInicioSesionBanda : MenuComponente
    {
        private Banda Banda { get; set; }
        private MenuCompuesto PrincipalUsuarioBanda { get; set; }

        public override void mostrar()
        {
            base.mostrar();

            var name = prompt("Ingrese nombre ");
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                Banda = AdoBanda.ADO.bandaPorNameYPass(name, pass);
                if (Banda is null)
                {
                    Console.WriteLine("nombre o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {
                    instanciarMenuesPara(Banda);
                    PrincipalUsuarioBanda.mostrar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {e.Message}");
                Console.ReadKey();
            }
        }

        private void instanciarMenuesPara(Banda banda)
        {
            var MenuAltaAlbum = new MenuAltaAlbum(banda);
            var MenuListaAlbumes = new MenuListaAlbumes() { Nombre = "Lista de Albumes" };
            var MenuAltaCancion = new MenuAltaCancion(MenuListaAlbumes);
            var MenuListaCanciones = new MenuListaCanciones() { Nombre = "Lista de Canciones" };

            var menuAlbum = new MenuCompuesto() { Nombre = "Albumes" };
            menuAlbum.agregarMenu(MenuAltaAlbum);
            menuAlbum.agregarMenu(MenuListaAlbumes);

            var menuCancion = new MenuCompuesto() { Nombre = "Canciones" };
            menuCancion.agregarMenu(MenuAltaCancion);
            menuCancion.agregarMenu(MenuListaCanciones);

            PrincipalUsuarioBanda = new MenuCompuesto() { Nombre = "Menu Banda" };
            PrincipalUsuarioBanda.agregarMenu(menuAlbum);
            PrincipalUsuarioBanda.agregarMenu(menuCancion);
        }
    }
}
