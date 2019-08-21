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

        public List<Reproduccion> Reproduccion { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string apellido, string mail, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Contraseña = contraseña;
        }

    }
}
