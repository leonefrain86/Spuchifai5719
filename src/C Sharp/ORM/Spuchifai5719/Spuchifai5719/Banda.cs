using NETCore.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Spuchifai5719
{
    [Table("Banda")]
    public class Banda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idBanda")]
        public int Id { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("anioFundacion"), Required]
        public short AnioFundacion { get; set; }

        public List<Album> Albumes { get; set; }

        [Column("contrasenia"), StringLength(256), Required]
        public string Password { get; set; }

        public Banda() { }

        public Banda(string nombre, string contrasenia)
        {
            this.Nombre = nombre;
            this.AnioFundacion = Convert.ToInt16(DateTime.Now.Year);
            this.Password = EncryptProvider.Sha256(contrasenia);
        }

        public int CantidadDeReproduccionesPorBanda()
        {
            return Albumes.Sum(a => a.CantidadDeReproducciones());
        }
    }
}
