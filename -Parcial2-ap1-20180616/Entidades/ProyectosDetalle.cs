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
    }
}
