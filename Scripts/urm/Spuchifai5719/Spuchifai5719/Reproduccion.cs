using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spuchifai5719
{
    [Table("Reproduccion")]
    public class Reproduccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idReproduccion")]
        public int Id { get; set; }

        [ForeignKey("idCliente"), Required]
        public Cliente cliente { get; set; }

        [ForeignKey("idCancion"), Required]
        public Cancion cancion { get; set; }

        [Column("fechaHora"), Required]
        public DateTime FechaHora { get; set; }

        public Reproduccion()
        {
            FechaHora = DateTime.Now;
        }
    }
}