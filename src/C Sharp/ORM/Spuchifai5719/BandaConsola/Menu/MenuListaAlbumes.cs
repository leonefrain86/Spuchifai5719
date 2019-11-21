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
            => Console.WriteLine($"{unAlbum.Id} - Nombre: {unAlbum.Nombre}- Nombre banda: {unAlbum.Banda.Nombre} - Cant. de Reproducciones: {unAlbum.CantidadDeReproducciones()}");

        public override List<Album> obtenerLista() 
            => AdoBanda.ADO.obtenerAlbumes();        
    }
}