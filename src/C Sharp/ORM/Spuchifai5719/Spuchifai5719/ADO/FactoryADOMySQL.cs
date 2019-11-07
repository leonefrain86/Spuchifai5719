using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Spuchifai5719.ADO
{
    public static class FactoryADOMySQL
    {
        public static MYSQLADO GetAdo(string cadena)
        {
            var dbContextOptions = new DbContextOptionsBuilder();
            dbContextOptions.UseMySQL(cadena);
            return new MYSQLADO(dbContextOptions.Options);
        }

        public static MYSQLADO GetAdoDesdeJson(string archivo, string atributoJson)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(archivo, optional: true, reloadOnChange: true)
                .Build();
            string cadena = config.GetConnectionString(atributoJson);
            return GetAdo(cadena);
        }
    }
}
