using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;

namespace AdministradorConsola.Menu
{
    public class CrearBanda : MenuComponente
    {
        public IADO ADO { get; set; }
        public Banda Banda { get; set; }
        public override void mostrar()
        {
            //TODO LEERINFO DE LABANDA
            //INSTANCIAR BANDA CON LA INFO QUE LEI
            base.mostrar();
            ADO.altaBanda(Banda);


        }
    }
}
