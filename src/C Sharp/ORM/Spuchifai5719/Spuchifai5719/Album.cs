using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Spuchifai5719
{
    [Table("Album")]
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idAlbum")]
        public byte Id { get; set; }

        [ForeignKey("idBanda"), Required]
        public Banda Banda { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("fechaLanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        public List<Cancion> Canciones { get; set; }

        public Album() { }

        public Album(string nombre, Banda unaBanda)
        {
            Nombre = nombre;
            FechaLanzamiento = DateTime.Now;
            Banda = unaBanda;
        }

        public int CantidadDeReproduccionesPorAlbum()
        {
            return Canciones.Sum(c => c.CantidadReproducciones());
        }
    }
}
