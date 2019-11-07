using Spuchifai5719.ADO;

namespace AdministradorConsola
{
    public static class ADOAdministrador
    {
        public static IADO ADO { get; set; } =
            FactoryADOMySQL.GetAdoDesdeJson("appsettings.json", "administrador");
    }
}
