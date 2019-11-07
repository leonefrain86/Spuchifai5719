using System;
using MenuesConsola;
using Spuchifai5719;
using Spuchifai5719.ADO;

namespace AdministradorConsola.Menu
{
    public class MenuAltaBanda : MenuComponente
    {
        public Banda banda { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre de la banda: ");
            var contrasenia = prompt("Ingrese la contraseña: ");
            banda = new Banda(nombre, contrasenia);
            try
            {
                ADOAdministrador.ADO.agregarBanda(Banda);
                Console.WriteLine("Categoria agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo cargar la categoria por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
