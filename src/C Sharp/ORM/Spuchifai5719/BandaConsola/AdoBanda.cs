using Spuchifai5719.ADO;

namespace AdministradorConsola.Menu
{
    public class AdoBanda
    {
        public static IADO ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "gerente");
    }
}
