using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace AdministradorConsola
{
    public class MenuListaCancion : MenuListador<Cancion>
    {
        public override void imprimirElemento(Cancion elemento)
          => Console.WriteLine($"{elemento.NroOrden} - {elemento.Nombre} - Álbum: {elemento.Album.Nombre} - Banda: {elemento.Album.Banda.Nombre}");

        public override List<Cancion> obtenerLista()
            => ADOAdministrador.ADO.obtenerCanciones();
    }
}