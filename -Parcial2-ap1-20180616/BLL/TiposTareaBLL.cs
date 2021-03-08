using _Parcial2_ap1_20180616.DAL;
using _Parcial2_ap1_20180616.Entidades;
using Microsoft.EntityFrameworkCore;
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
        
        private static bool Insertar(Proyectos proyectos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Proyectos proyectos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
    }
}
