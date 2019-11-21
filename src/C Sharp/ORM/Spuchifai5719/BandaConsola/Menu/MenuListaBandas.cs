using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;
using BandaConsola;

namespace BandaConsola.Menu
{
    public class MenuListaBandas : MenuListador<Banda>
    {
        public override void imprimirElemento(Banda elemento) 
            => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Banda> obtenerLista()
            => ADOBanda.ADO.obtenerBandas();
    }
}