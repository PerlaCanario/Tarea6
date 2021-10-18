using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        [ForeignKey("RolId")]
        public virtual Roles Rol { get; set; }
    }
}
