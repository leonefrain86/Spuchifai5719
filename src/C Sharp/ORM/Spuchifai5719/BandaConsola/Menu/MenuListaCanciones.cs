using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace BandaConsola.Menu
{
    public class MenuListaCanciones : MenuListador<Cancion>
    {
        public Banda Banda { get; set; }

        public override void imprimirElemento(Cancion unaCancion)
        {
             Console.WriteLine($"{unaCancion.Id} - Nombre: {unaCancion.Nombre} - Cant. de Reproducciones: {unaCancion.CantidadReproducciones()} ");
        }
        public override List<Cancion> obtenerLista()
            => AdoBanda.ADO.obtenerCancionesParaBanda(Banda);
    }
}