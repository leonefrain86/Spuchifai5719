using NETCore.Encrypt;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spuchifai5719
{
    [Table("Cliente")]
    public class Cliente : ConListaReproduccion
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

        [Column("contraseña"), StringLength(64), Required]
        public string Password { get; set; }       

        public Cliente() : base() {}

        public Cliente(string nombre, string apellido, string mail, string contrasenia) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Password = contrasenia;

        }
        public void ReproducirCancion(Cancion cancion) 
        {
            Reproduccion unaReproduccion = new Reproduccion(this, cancion);
            AgregarReproduccion(unaReproduccion);
            cancion.AgregarReproduccion(unaReproduccion);
        }
    }
}
