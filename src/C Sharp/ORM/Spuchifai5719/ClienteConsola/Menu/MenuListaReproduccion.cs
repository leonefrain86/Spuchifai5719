using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace ClienteConsola.Menu
{
    public class MenuListaReproduccion : MenuListador<Reproduccion>
    {
        public Cliente cliente { get; set; }
        public override void imprimirElemento(Reproduccion elemento)
          => Console.WriteLine($"{elemento.Id} - Cliente: {elemento.cliente.Nombre} - Canción: {elemento.cancion.Nombre} - Hora: {elemento.FechaHora}");

        public override List<Reproduccion> obtenerLista()
            => ADOCliente.ADO.obtenerReproduccionesParaCliente(cliente);
    }
}
