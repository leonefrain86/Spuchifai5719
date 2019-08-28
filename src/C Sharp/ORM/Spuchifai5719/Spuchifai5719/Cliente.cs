using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spuchifai5719
{
    [Table("Cliente")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCliente")]
        public int Id { get; set; }

        [Column("nombre"), StringLength(45), Required] 
        public string Nombre { get; set; }

        [Column("apellido"), StringLength(45), Required]
        public string Apellido { get; set; }

        [Column("mail"), StringLength(45), Required]
        public string Mail { get; set; }

        [Column("contraseña"), StringLength(45), Required]
        public string Contraseña { get; set; }

        public List<Reproduccion> Reproducciones { get; set; }

        public Cliente()
        {
            Reproducciones = new List<Reproduccion>();
        }
        public Cliente(string nombre, string apellido, string mail, string contraseña) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Contraseña = contraseña;

        }
        public void ReproducirCancion(Cancion cancion)
        {
            Reproduccion unaReproduccion = new Reproduccion(this, cancion);
            Reproducciones.Add(unaReproduccion);
            cancion.AgregarReproduccion(unaReproduccion);
        }


    }
}
