using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace BandaConsola.Menu
{
    public class MenuListaBandas : MenuListador<Banda>
    {
        public override void imprimirElemento(Banda unaBanda) 
            => Console.WriteLine($"{unaBanda.Id} - {unaBanda.Nombre}");

        public override List<Banda> obtenerLista()
            => AdoBanda.ADO.obtenerBandas();
    }
}