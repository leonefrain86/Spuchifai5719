using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using NETCore.Encrypt;
using System.Linq;

namespace Spuchifai5719.ADO
{
    public class MYSQLADO : DbContext, IADO
    {
        DbSet<Album> Albumes { get; set; }
        DbSet<Banda> Bandas { get; set; }
        DbSet<Cancion> Canciones { get; set; }
        DbSet<Reproduccion> Reproduciones { get; set; }
        DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseMySQL("server=localhost;database=Spuchifai;uid=root;pwd=root");
        }
        public void altaAlbum(Album album)
        {
            Albumes.Add(album);
            SaveChanges();
        }

        public void altaBanda(Banda banda)
        {
            Bandas.Add(banda);
            SaveChanges();
        }

        public void altaCancion(Cancion cancion)
        {
            Canciones.Add(cancion);
            SaveChanges();
        }

        public void altaCliente(Cliente cliente)
        {
            cliente.Password = EncryptProvider.Sha256(cliente.Password);
            Clientes.Add(cliente);
            SaveChanges();
        }

        public Cliente clientePorUserYPass(string mailUser, string pass)
        {
            var passEncrip = EncryptProvider.Sha256(pass);
            return Clientes.FirstOrDefault(c => (c.Mail == mailUser && c.Password == passEncrip));
        }

        public List<Cancion> traerCanciones()
        {        
            return Canciones.ToList();
        }

        public void actualizarCliente(Cliente cliente)
        {
            Update<Cliente>(cliente);
            SaveChanges();
        }
    }
}
