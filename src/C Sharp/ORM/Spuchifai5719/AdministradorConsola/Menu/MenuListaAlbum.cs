using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace AdministradorConsola
{
    internal class MenuListaAlbum : MenuListador<Album>
    {
        public override void imprimirElemento(Album elemento)
          => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Album> obtenerLista()
            => ADOAdministrador.ADO.obtenerAlbumes();
    }
}