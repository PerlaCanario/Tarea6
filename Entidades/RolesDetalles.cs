using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class RolesDetalles
    {
        [Key]

        public int Id { get; set; }
        public int RolID { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }

        public RolesDetalles()
        {
            Id = 0;
            RolID = 0;
            PermisoId = 0;
            esAsignado = false;
        }
        public RolesDetalles(int id, int rolId, int permisoId, bool EsAsignado)
        {
            Id = id;
            RolID = rolId;
            PermisoId = permisoId;
            esAsignado = EsAsignado;
        }
    }
}
