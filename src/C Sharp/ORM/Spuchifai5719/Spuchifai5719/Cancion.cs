using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spuchifai5719
{
    [Table("Cancion")]
    public class Cancion : ConListaReproduccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCancion")]
        public int Id { get; set; }

        [ForeignKey("idAlbum"), Required]
        public Album Album { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("nroOrden"), Required]
        public byte NroOrden { get; set; }

        public Cancion(): base() { }

        public Cancion(string nombre, byte nroOrden, Album unAlbum): this ()
        {
            Nombre = nombre;
            NroOrden = nroOrden;
            Album = unAlbum;
        }

        public int CantidadReproducciones()
        {
            return Reproducciones.Count;
        }
    }
}
