using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Parcial2_ap1_20180616.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TipoTareaId { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public ProyectosDetalle()
        {
            DetalleId = 0;
            ProyectoId = 0;
            TipoTareaId = 0;
            Requerimiento = string.Empty;
            Tiempo = 0;
        }

        public ProyectosDetalle(int proyectoId, int tipoTareaId, string requerimiento, int tiempo)
        {
            ProyectoId = proyectoId;
            TipoTareaId = tipoTareaId;
            Requerimiento = requerimiento;
            Tiempo = tiempo;
        }
        public ProyectosDetalle(int detalleId, int proyectoId, int tipoTareaId, string requerimiento, int tiempo)
        {
            DetalleId = detalleId;
            ProyectoId = proyectoId;
            TipoTareaId = tipoTareaId;
            Requerimiento = requerimiento;
            Tiempo = tiempo;
        }

    }
}
