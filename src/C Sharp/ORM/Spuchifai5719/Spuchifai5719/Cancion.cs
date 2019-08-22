using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spuchifai5719
{
    [Table("Cancion")]
    public class Cancion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCancion")]
        public byte Id { get; set; }

        [ForeignKey("idAlbum"), Required]
        public Album Album { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("nroOrden"), Required]
        public byte NroOrden { get; set; }

        public List<Reproduccion> Reproducciones { get; set; }

        public Cancion() { }

        public Cancion(string nombre, byte nroOrden)
        {
            Nombre = nombre;
            NroOrden = nroOrden;
        }

        public void AgregarReproduccion(Reproduccion reproduccion)
        {
            Reproducciones.Add(reproduccion);
        }

        public int CantidadReproducciones()
        {
            return Reproducciones.Count;
        }
    }
}
