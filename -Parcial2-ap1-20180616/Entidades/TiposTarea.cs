using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Parcial2_ap1_20180616.Entidades
{
    public class TiposTarea
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
        public TiposTarea()
        {
            TipoId = 0;
            Descripcion = "";
            Requerimiento = "";
            Tiempo = 0;
        }
    }
}
