using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _Parcial2_ap1_20180616.BLL;
using _Parcial2_ap1_20180616.Entidades;

namespace _Parcial2_ap1_20180616.UI.Consultas
{
    public partial class cProyectos : Form
    {
        public cProyectos()
        {
            InitializeComponent();
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Proyectos>();

            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(r => r.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1:
                        lista = ProyectosBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 2:
                        lista = ProyectosBLL.GetList(r => r.TiempoTotal == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = ProyectosBLL.GetList(r => true);

            ProyectosDataGridView.DataSource = null;
            ProyectosDataGridView.DataSource = lista;
        }
    }
}
