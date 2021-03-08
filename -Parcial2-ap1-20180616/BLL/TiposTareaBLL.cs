using _Parcial2_ap1_20180616.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parcial2_ap1_20180616.BLL
{
    public class TiposTareaBLL
    {
        public static bool Existe(string descripcion)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                encontrado = contexto.Proyectos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
    }
}
