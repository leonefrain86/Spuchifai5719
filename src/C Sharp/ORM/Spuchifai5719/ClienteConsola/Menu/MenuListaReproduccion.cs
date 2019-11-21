using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace ClienteConsola.Menu
{
    public class MenuListaReproduccion : MenuListador<Reproduccion>
    {
        public override void imprimirElemento(Reproduccion elemento)
          => Console.WriteLine($"{elemento.Id}");

        public override List<Reproduccion> obtenerLista()
            => ADOCliente.ADO.obtenerReproducciones();
    }
}
