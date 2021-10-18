using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public string DetallePermiso { get; set; }
        public string Nombre { get; set; }
        public bool vecesAcignada { get; set; }


        [ForeignKey("PermisosId")]
        public virtual Permisos permisos { get; set; }
    }
}
