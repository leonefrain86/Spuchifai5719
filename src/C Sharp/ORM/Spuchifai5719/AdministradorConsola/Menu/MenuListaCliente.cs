using System;
using System.Collections.Generic;
using System.Text;
using Spuchifai5719;
using MenuesConsola;

namespace AdministradorConsola.Menu
{
    public class MenuListaCliente : MenuListador<Cliente>
    {
        public override void imprimirElemento(Cliente elemento)
          => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");

        public override List<Cliente> obtenerLista()
            => ADOAdministrador.ADO.obtenerClientes();
    }
}
