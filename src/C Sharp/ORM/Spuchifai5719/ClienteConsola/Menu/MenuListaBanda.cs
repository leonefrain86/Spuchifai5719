using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;


namespace ClienteConsola.Menu
{
    public class MenuListaBanda : MenuListador<Banda>
    {
        public override void imprimirElemento(Banda elemento)
            => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Banda> obtenerLista()
            => ADOCliente.ADO.obtenerBandas();
    }
}
