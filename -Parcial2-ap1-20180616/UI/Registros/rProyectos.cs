using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _Parcial2_ap1_20180616.Entidades;
using _Parcial2_ap1_20180616.DAL;
using _Parcial2_ap1_20180616.BLL;

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
            if(DetalleProyecto.Count == 0)
            {
                ProyectosErrorProvider.SetError(ProyectoDetalleDataGridView, "Agregue un tipo de tarea");
                validado = false;
            }
            if(ProyectosBLL.Existe(DescripcionTextBox.Text))
            {
                ProyectosErrorProvider.SetError(DescripcionTextBox, "Esta descripcion ya existe");
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
            DetalleProyecto = proyecto.DetalleProyecto;
            LlenarGrid();
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
            Proyectos proyecto;
            
            if (!Validar())
                return;

            proyecto = LlenaClase();
            var paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El proyecto ha sido guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El proyecto no ha sido guardado", "Error Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void rProyectos_Load(object sender, EventArgs e)
        {
            TiposTareasComboBox.DataSource = TiposTareaBLL.GetTareas();
            TiposTareasComboBox.DisplayMember = "Descripcion";
            TiposTareasComboBox.ValueMember = "TipoId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var proyecto = new Proyectos();
            int id = (int)ProyectoIdNumericUpDown.Value;

            Limpiar();
            proyecto = ProyectosBLL.Buscar(id);
            if (proyecto != null)
                LlenaCampos(proyecto);
            else
                MessageBox.Show("Proyecto no encontrado en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TiposTareasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TiposTareasComboBox.SelectedIndex == 0)
            {
                RequerimientoTextBox.Text = TiposTareaBLL.BuscarRequerimiento(TiposTareasComboBox.SelectedIndex + 1);
                TiempoTextBox.Text = TiposTareaBLL.BuscarTiempo(TiposTareasComboBox.SelectedIndex + 1);
            }
            else if (TiposTareasComboBox.SelectedIndex == 1)
            {
                RequerimientoTextBox.Text = TiposTareaBLL.BuscarRequerimiento(TiposTareasComboBox.SelectedIndex + 1);
                TiempoTextBox.Text = TiposTareaBLL.BuscarTiempo(TiposTareasComboBox.SelectedIndex + 1);
            }
            else if (TiposTareasComboBox.SelectedIndex == 2)
            {
                RequerimientoTextBox.Text = TiposTareaBLL.BuscarRequerimiento(TiposTareasComboBox.SelectedIndex + 1);
                TiempoTextBox.Text = TiposTareaBLL.BuscarTiempo(TiposTareasComboBox.SelectedIndex + 1);
            }
            else if (TiposTareasComboBox.SelectedIndex == 3)
            {
                RequerimientoTextBox.Text = TiposTareaBLL.BuscarRequerimiento(TiposTareasComboBox.SelectedIndex + 1);
                TiempoTextBox.Text = TiposTareaBLL.BuscarTiempo(TiposTareasComboBox.SelectedIndex + 1);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ProyectoDetalleDataGridView.DataSource != null)
                DetalleProyecto = (List<ProyectosDetalle>)ProyectoDetalleDataGridView.DataSource;
            
            DetalleProyecto.Add(new ProyectosDetalle()
            {
                ProyectoId = (int)ProyectoIdNumericUpDown.Value,
                TipoTareaId = Convert.ToInt32(TiposTareasComboBox.SelectedIndex) + 1,
                Requerimiento = RequerimientoTextBox.Text,
                Tiempo = Convert.ToInt32(TiempoTextBox.Text)
            });

            LlenarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((ProyectoDetalleDataGridView.Rows.Count > 0) && ProyectoDetalleDataGridView.CurrentRow != null)
            {
                DetalleProyecto.RemoveAt(ProyectoDetalleDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)ProyectoIdNumericUpDown.Value;
            ProyectosErrorProvider.Clear();

            if(ProyectosBLL.Eliminar(id))
            {
                MessageBox.Show("El proyecto ha sido eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("El proyecto no ha sido eliminado", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
