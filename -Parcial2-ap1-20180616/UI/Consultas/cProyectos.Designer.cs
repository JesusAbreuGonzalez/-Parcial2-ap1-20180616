
namespace _Parcial2_ap1_20180616.UI.Consultas
{
    partial class cProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ProyectosDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.buscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(660, 46);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(91, 32);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ProyectosDataGridView
            // 
            this.ProyectosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyectosDataGridView.Location = new System.Drawing.Point(14, 88);
            this.ProyectosDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProyectosDataGridView.MinimumSize = new System.Drawing.Size(737, 409);
            this.ProyectosDataGridView.Name = "ProyectosDataGridView";
            this.ProyectosDataGridView.RowHeadersWidth = 51;
            this.ProyectosDataGridView.RowTemplate.Height = 25;
            this.ProyectosDataGridView.Size = new System.Drawing.Size(737, 409);
            this.ProyectosDataGridView.TabIndex = 11;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(192, 25);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(58, 20);
            this.CriterioLabel.TabIndex = 10;
            this.CriterioLabel.Text = "Criterio";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(192, 49);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(450, 27);
            this.CriterioTextBox.TabIndex = 9;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Proyecto Id",
            "Descripción",
            "Tiempo Total"});
            this.FiltroComboBox.Location = new System.Drawing.Point(14, 49);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(159, 28);
            this.FiltroComboBox.TabIndex = 8;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(14, 25);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(43, 20);
            this.FiltroLabel.TabIndex = 7;
            this.FiltroLabel.Text = "Filtro";
            // 
            // cProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 511);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ProyectosDataGridView);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cProyectos";
            this.Text = "Consulta de Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.ProyectosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ProyectosDataGridView;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
    }
}