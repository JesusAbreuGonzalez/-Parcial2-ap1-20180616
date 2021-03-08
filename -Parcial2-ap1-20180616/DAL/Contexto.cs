using System;
using System.Collections.Generic;
using _Parcial2_ap1_20180616.Entidades;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _Parcial2_ap1_20180616.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<ProyectosDetalle> ProyectosDetalle { get; set; }
        public DbSet<TiposTarea> TareasTipos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionProyectos.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TiposTarea>().HasData(
               new TiposTarea() { TipoId = 1, Descripcion = "Análisis", Requerimiento = "Analizar la opción de clientes", Tiempo = 120 },
               new TiposTarea() { TipoId = 2, Descripcion = "Diseño", Requerimiento = "Hacer un diseño excelente", Tiempo = 60 },
               new TiposTarea() { TipoId = 3, Descripcion = "Programación", Requerimiento = "Programar todo el registro", Tiempo = 240 },
               new TiposTarea() { TipoId = 4, Descripcion = "Prueba", Requerimiento = "Probar con mucho cuidado", Tiempo = 30 }
           );
        }
    }
}
