using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;


namespace ClienteConsola
{
    public class MenuListaCancion : MenuListador<Cancion>
    {
        public override void imprimirElemento(Cancion elemento)
          => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Cancion> obtenerLista()
            => ADOCliente.ADO.obtenerCanciones();
    }
}