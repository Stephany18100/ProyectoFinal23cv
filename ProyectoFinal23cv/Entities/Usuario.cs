using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23cv.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuario{ get; set; }
        //[Required] de ahuevo se tiene que ponee
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int? FKRol { get; set; } //? no es obligatorio

        public Rol Roles { get; set; }
    }
}
