using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public Banda() { }

        
    }
}
