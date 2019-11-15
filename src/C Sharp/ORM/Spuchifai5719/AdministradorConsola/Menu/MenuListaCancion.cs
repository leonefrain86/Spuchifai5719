using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace AdministradorConsola
{
    internal class MenuListaCancion : MenuListador<Cancion>
    {
        public override void imprimirElemento(Cancion elemento)
          => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Cancion> obtenerLista()
            => ADOAdministrador.ADO.obtenerCanciones();
    }
}