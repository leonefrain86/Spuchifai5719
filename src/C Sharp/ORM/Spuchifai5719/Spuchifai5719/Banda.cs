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
        public DateTime AnioFundacion { get; set; }

        public List<Album> Albumes { get; set; }

        public Banda() { }

        public Banda(string nombre)
        {
            Nombre = nombre;
            AnioFundacion = DateTime.Now;
        }

        public int CantidadDeReproduccionesPorBanda()
        {
            return Albumes.Sum(a => a.CantidadDeReproduccionesPorAlbum());
        }
    }
}
