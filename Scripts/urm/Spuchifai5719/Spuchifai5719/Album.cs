using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column("fechaLanzamiento"), Required]
        public DateTime FechaLanzamiento { get; set; }

        public Album() { }

        public Album(string nombre)
        {
            Nombre = nombre;
            FechaLanzamiento = DateTime.Now;
        }
    }
}
