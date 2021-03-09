
using System;

namespace _Parcial2_ap1_20180616.UI.Registros
{
    partial class rProyectos
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
            this.components = new System.ComponentModel.Container();
            this.ProyectosErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.ProyectoDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.RequerimientoTextBox = new System.Windows.Forms.TextBox();
            this.TiposTareasComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TiempoLabel = new System.Windows.Forms.Label();
            this.RequerimientoLabel = new System.Windows.Forms.Label();
            this.TipoTareaLabel = new System.Windows.Forms.Label();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TiempoTotalLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.ProyectoIdLabel = new System.Windows.Forms.Label();
            this.TiempoTotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectosErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            this.DetalleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProyectosErrorProvider
            // 
            this.ProyectosErrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(225, 674);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(98, 41);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.Guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(120, 674);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 41);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NuevoButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.nuevo__1_;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(15, 674);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(98, 41);
            this.NuevoButton.TabIndex = 21;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoverButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.Remover;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(7, 349);
            this.RemoverButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(95, 27);
            this.RemoverButton.TabIndex = 8;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // ProyectoDetalleDataGridView
            // 
            this.ProyectoDetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyectoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyectoDetalleDataGridView.Location = new System.Drawing.Point(7, 104);
            this.ProyectoDetalleDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProyectoDetalleDataGridView.Name = "ProyectoDetalleDataGridView";
            this.ProyectoDetalleDataGridView.RowHeadersWidth = 51;
            this.ProyectoDetalleDataGridView.RowTemplate.Height = 25;
            this.ProyectoDetalleDataGridView.Size = new System.Drawing.Size(676, 237);
            this.ProyectoDetalleDataGridView.TabIndex = 7;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(466, 65);
            this.TiempoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.ReadOnly = true;
            this.TiempoTextBox.Size = new System.Drawing.Size(116, 27);
            this.TiempoTextBox.TabIndex = 6;
            // 
            // RequerimientoTextBox
            // 
            this.RequerimientoTextBox.Location = new System.Drawing.Point(162, 65);
            this.RequerimientoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequerimientoTextBox.Name = "RequerimientoTextBox";
            this.RequerimientoTextBox.ReadOnly = true;
            this.RequerimientoTextBox.Size = new System.Drawing.Size(297, 27);
            this.RequerimientoTextBox.TabIndex = 5;
            // 
            // TiposTareasComboBox
            // 
            this.TiposTareasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiposTareasComboBox.FormattingEnabled = true;
            this.TiposTareasComboBox.Location = new System.Drawing.Point(7, 65);
            this.TiposTareasComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TiposTareasComboBox.Name = "TiposTareasComboBox";
            this.TiposTareasComboBox.Size = new System.Drawing.Size(148, 28);
            this.TiposTareasComboBox.TabIndex = 4;
            this.TiposTareasComboBox.SelectedIndexChanged += new System.EventHandler(this.TiposTareasComboBox_SelectedIndexChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.agregar;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(588, 65);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(95, 27);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TiempoLabel
            // 
            this.TiempoLabel.AutoSize = true;
            this.TiempoLabel.Location = new System.Drawing.Point(466, 41);
            this.TiempoLabel.Name = "TiempoLabel";
            this.TiempoLabel.Size = new System.Drawing.Size(60, 20);
            this.TiempoLabel.TabIndex = 2;
            this.TiempoLabel.Text = "Tiempo";
            // 
            // RequerimientoLabel
            // 
            this.RequerimientoLabel.AutoSize = true;
            this.RequerimientoLabel.Location = new System.Drawing.Point(162, 42);
            this.RequerimientoLabel.Name = "RequerimientoLabel";
            this.RequerimientoLabel.Size = new System.Drawing.Size(107, 20);
            this.RequerimientoLabel.TabIndex = 1;
            this.RequerimientoLabel.Text = "Requerimiento";
            // 
            // TipoTareaLabel
            // 
            this.TipoTareaLabel.AutoSize = true;
            this.TipoTareaLabel.Location = new System.Drawing.Point(7, 42);
            this.TipoTareaLabel.Name = "TipoTareaLabel";
            this.TipoTareaLabel.Size = new System.Drawing.Size(104, 20);
            this.TipoTareaLabel.TabIndex = 0;
            this.TipoTareaLabel.Text = "Tipos de tarea";
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(15, 38);
            this.ProyectoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(155, 27);
            this.ProyectoIdNumericUpDown.TabIndex = 26;
            // 
            // TiempoTotalLabel
            // 
            this.TiempoTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TiempoTotalLabel.AutoSize = true;
            this.TiempoTotalLabel.Location = new System.Drawing.Point(500, 684);
            this.TiempoTotalLabel.Name = "TiempoTotalLabel";
            this.TiempoTotalLabel.Size = new System.Drawing.Size(97, 20);
            this.TiempoTotalLabel.TabIndex = 24;
            this.TiempoTotalLabel.Text = "Tiempo Total";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::_Parcial2_ap1_20180616.Properties.Resources.buscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(177, 38);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 27);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.ProyectoDetalleDataGridView);
            this.DetalleGroupBox.Controls.Add(this.TiempoTextBox);
            this.DetalleGroupBox.Controls.Add(this.RequerimientoTextBox);
            this.DetalleGroupBox.Controls.Add(this.TiposTareasComboBox);
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.TiempoLabel);
            this.DetalleGroupBox.Controls.Add(this.RequerimientoLabel);
            this.DetalleGroupBox.Controls.Add(this.TipoTareaLabel);
            this.DetalleGroupBox.Location = new System.Drawing.Point(15, 282);
            this.DetalleGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetalleGroupBox.Size = new System.Drawing.Size(690, 384);
            this.DetalleGroupBox.TabIndex = 19;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle de tareas a realizar";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(15, 184);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(689, 89);
            this.DescripcionTextBox.TabIndex = 18;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(15, 110);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(155, 27);
            this.FechaDateTimePicker.TabIndex = 17;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(15, 160);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 16;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(12, 86);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(47, 20);
            this.FechaLabel.TabIndex = 15;
            this.FechaLabel.Text = "Fecha";
            // 
            // ProyectoIdLabel
            // 
            this.ProyectoIdLabel.AutoSize = true;
            this.ProyectoIdLabel.Location = new System.Drawing.Point(15, 14);
            this.ProyectoIdLabel.Name = "ProyectoIdLabel";
            this.ProyectoIdLabel.Size = new System.Drawing.Size(22, 20);
            this.ProyectoIdLabel.TabIndex = 14;
            this.ProyectoIdLabel.Text = "Id";
            // 
            // TiempoTotalTextBox
            // 
            this.TiempoTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TiempoTotalTextBox.Location = new System.Drawing.Point(603, 681);
            this.TiempoTotalTextBox.Name = "TiempoTotalTextBox";
            this.TiempoTotalTextBox.Size = new System.Drawing.Size(102, 27);
            this.TiempoTotalTextBox.TabIndex = 27;
            // 
            // rProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 731);
            this.Controls.Add(this.TiempoTotalTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.TiempoTotalLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.ProyectoIdLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(735, 778);
            this.Name = "rProyectos";
            this.Text = "Registro de Proyectos";
            this.Load += new System.EventHandler(this.rProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyectosErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ProyectosErrorProvider;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.Label TiempoTotalLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView ProyectoDetalleDataGridView;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.TextBox RequerimientoTextBox;
        private System.Windows.Forms.ComboBox TiposTareasComboBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label TiempoLabel;
        private System.Windows.Forms.Label RequerimientoLabel;
        private System.Windows.Forms.Label TipoTareaLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label ProyectoIdLabel;
        private System.Windows.Forms.TextBox TiempoTotalTextBox;
    }
}