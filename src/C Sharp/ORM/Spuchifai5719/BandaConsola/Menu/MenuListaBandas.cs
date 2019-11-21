using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;
using BandaConsola;
namespace BandaConsola.Menu
{
    internal class MenuListaBandas : MenuListador<Banda>
    {
        public override void imprimirElemento(Banda unaBanda) 
            => Console.WriteLine($"{unaBanda.Id} - {unaBanda.Nombre}");

        public override List<Banda> obtenerLista()
            => ADOBanda.ADO.obtenerBandas();
    }
}