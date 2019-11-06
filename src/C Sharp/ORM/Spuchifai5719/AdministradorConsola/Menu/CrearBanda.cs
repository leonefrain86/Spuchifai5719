using System;
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
            Console.WriteLine("Ingrese nombre de banda: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña: ");
            string pass = Console.ReadLine();

            Banda = new Banda(name, pass);
            //TODO LEERINFO DE LABANDA
            //INSTANCIAR BANDA CON LA INFO QUE LEI
            base.mostrar();
            ADO.altaBanda(Banda);
        }

    }
}
