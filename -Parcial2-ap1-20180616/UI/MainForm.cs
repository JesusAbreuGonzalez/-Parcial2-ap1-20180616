using _Parcial2_ap1_20180616.UI.Consultas;
using _Parcial2_ap1_20180616.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Parcial2_ap1_20180616.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Registros
            this.rProyectosToolStripMenuItem.Click += new EventHandler(this.rProyectosToolStripMenuItem_ItemClicked);

            //Consultas
            this.cProyectosToolStripMenuItem.Click += new EventHandler(this.cProyectosToolStripMenuItem_ItemClicked);
        }

        private void cProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new cProyectos();
            proyecto.MdiParent = this;
            proyecto.Show();
        }

        private void rProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new rProyectos();
            proyecto.MdiParent = this;
            proyecto.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
