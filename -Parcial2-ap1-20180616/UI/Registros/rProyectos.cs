using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _Parcial2_ap1_20180616.Entidades;
using _Parcial2_ap1_20180616.DAL;

namespace _Parcial2_ap1_20180616.UI.Registros
{
    public partial class rProyectos : Form
    {
        public List<ProyectosDetalle> DetalleProyecto { get; set; }

        public rProyectos()
        {
            InitializeComponent();
            this.DetalleProyecto = new List<ProyectosDetalle>();
        }

        private void LlenarGrid()
        {
            ProyectoDetalleDataGridView.DataSource = null;
            ProyectoDetalleDataGridView.DataSource = this.DetalleProyecto;
        }

        private bool Validar()
        {
            bool validado = true;

            if(DescripcionTextBox.Text == "")
            {
                ProyectosErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                validado = false;
            }

            return validado;
        }

        private Proyectos LlenaClase()
        {
            var proyecto = new Proyectos();
            proyecto.Descripcion = DescripcionTextBox.Text;
            proyecto.ProyectoId = (int)ProyectoIdNumericUpDown.Value;
            proyecto.Fecha = FechaDateTimePicker.Value;
            proyecto.TiempoTotal += Convert.ToInt32(TiempoTextBox.Text);
            proyecto.DetalleProyecto = this.DetalleProyecto;

            return proyecto;
        }

        private void LlenaCampos(Proyectos proyecto)
        {
            ProyectoIdNumericUpDown.Value = proyecto.ProyectoId;
            DescripcionTextBox.Text = proyecto.Descripcion;
            FechaDateTimePicker.Value = proyecto.Fecha;
            TiempoTotalTextBox.Text = Convert.ToString(proyecto.TiempoTotal);
        }

        private void Limpiar()
        {
            ProyectoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            ProyectosErrorProvider.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            TiempoTotalTextBox.Clear();
            DetalleProyecto = new List<ProyectosDetalle>();
            LlenarGrid();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
