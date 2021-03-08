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

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
