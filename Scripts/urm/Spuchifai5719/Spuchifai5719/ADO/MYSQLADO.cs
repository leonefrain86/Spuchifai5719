using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Spuchifai5719.ADO
{
    class MYSQLADO : DbContext, IADO
    {
        DbSet<Album> Albumes { get; set; }
        DbSet<Banda> Bandas { get; set; }
        DbSet<Cancion> Canciones { get; set; }
        DbSet<Reproduccion> Reproduciones { get; set; }
        DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseMySQL("server=localhost;database=Escuela;uid=root;pwd=admin");
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
            Clientes.Add(cliente);
            SaveChanges();
        }

      
    }
}
