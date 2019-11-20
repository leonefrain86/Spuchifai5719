using Spuchifai5719.ADO;

namespace AdministradorConsola
{
    public static class AdoBanda
    {
        public static IADO ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "banda");
    }
}
