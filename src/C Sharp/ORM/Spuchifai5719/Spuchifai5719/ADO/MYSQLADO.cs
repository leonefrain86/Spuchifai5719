﻿using Microsoft.EntityFrameworkCore;
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
        DbSet<Reproduccion> Reproducciones { get; set; }
        DbSet<Cliente> Clientes { get; set; }

        public MYSQLADO() : base() { }

        internal MYSQLADO(DbContextOptions dbo) : base(dbo) { }

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
            Clientes.Add(cliente);
            SaveChanges();
        }

        public void altaReproduccion(Reproduccion reproduccion)
        {
            Reproducciones.Add(reproduccion);
            SaveChanges();
        }

        public Cliente clientePorUserYPass(string mailUser, string pass)
        {
            return Clientes.FirstOrDefault(c => (c.Mail == mailUser && c.Password == pass));
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

        public List<Banda> obtenerBandas() => Bandas.ToList();

        public List<Album> obtenerAlbumes() 
            =>  Albumes.
                Include(c=>c.Banda).
                ToList();

        public List<Cancion> obtenerCanciones() 
            =>  Canciones.
                Include(c=>c.Album).
                ThenInclude(a=>a.Banda).
                ToList();

        public List<Cliente> obtenerClientes() => Clientes.ToList();

        public List<Reproduccion> obtenerReproducciones() 
            =>  Reproducciones.
                Include(c => c.cliente).
                Include(a => a.cancion).
                ToList();
    }
}
