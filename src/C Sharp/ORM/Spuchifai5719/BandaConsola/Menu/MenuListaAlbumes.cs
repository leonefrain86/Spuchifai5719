using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace BandaConsola.Menu
{
    public class MenuListaAlbumes : MenuListador<Album>
    {
        public override void imprimirElemento(Album unAlbum) 
            => Console.WriteLine($"{unAlbum.Id} - {unAlbum.Nombre}");

        public override List<Album> obtenerLista()
            => AdoBanda.ADO.obtenerAlbumes();        
    }
}