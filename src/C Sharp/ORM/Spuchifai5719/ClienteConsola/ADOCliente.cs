using Spuchifai5719.ADO;
namespace ClienteConsola
{
    public static class ADOCliente
    {
        public static IADO ADO { get; set; } =
            FactoryADOMySQL.GetAdoDesdeJson("appsettings.json", "cliente");
    }
}
