using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;


namespace ClienteConsola
{
    public class MenuListaAlbum : MenuListador<Album>
    {
        public override void imprimirElemento(Album elemento)
          => Console.WriteLine($"{elemento.Nombre} - Banda: {elemento.Banda.Nombre}");

        public override List<Album> obtenerLista()
            => ADOCliente.ADO.obtenerAlbumes();
    }
}