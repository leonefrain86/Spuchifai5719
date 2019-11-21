using Spuchifai5719.ADO;

namespace BandaConsola
{
    public static class ADOBanda
    {
        public static IADO ADO { get; set; } =
            FactoryADOMySQL.GetAdoDesdeJson("appsettings.json", "banda");
    }
}
