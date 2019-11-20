using System;

namespace BandaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var MenuListaBandas = new MenuListaBandas() { Nombre = "Lista de Bandas"};
            var MenuAltaAlbum = new MenuAltaAlbum(MenuListaBandas);
            var MenuListaAlbumes = new MenuListaAlbumes() { Nombre = "Lista de Albumes"};
            var MenuAltaCancion = new MenuAltaCancion(MenuListaAlbumes);
            var MenuListaCanciones = new MenuListaCanciones() { Nombre = "Lista de Canciones"};

            var menuAlbum = new MenuCompuesto() { Nombre = "Albumes" };
            menuAlbum.agregarMenu(MenuAltaAlbum);
            menuAlbum.agregarMenu(MenuListaAlbumes);

            var menuCancion = new MenuCompuesto() { Nombre = "Canciones" };
            menuCancion.agregarMenu(MenuAltaCancion);
            menuCancion.agregarMenu(MenuListaCanciones);

            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Banda" };
            menuPrincipal.agregarMenu(menuAlbum);
            menuPrincipal.agregarMenu(menuCancion);

            menuPrincipal.mostrar();  
        }
    }
}
