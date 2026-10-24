namespace PeliculasBD
{
    partial class Clasificacion
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripLabel();
            btnEditar = new ToolStripLabel();
            btnEliminar = new ToolStripLabel();
            btnGuardar = new ToolStripLabel();
            btnCancelar = new ToolStripLabel();
            btnObtener = new ToolStripLabel();
            btnSalir = new ToolStripLabel();
            dgvClasificacion = new DataGridView();
            lbidClasificacion = new Label();
            lbclave = new Label();
            lbdescripcion = new Label();
            lbfechaHoraCreacion = new Label();
            txtidClasificacion = new TextBox();
            txtclave = new TextBox();
            txtdescripcion = new TextBox();
            dateTimePickerFechaCreacion = new DateTimePicker();
            txtClaveClasif = new TextBox();
            txtDescrip = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1242, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(64, 25);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(57, 25);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(74, 25);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 25);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 25);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnObtener
            // 
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(129, 25);
            btnObtener.Text = "Obtener Datos";
            btnObtener.Click += btnObtener_Click;
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 25);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvClasificacion
            // 
            dgvClasificacion.AllowUserToAddRows = false;
            dgvClasificacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClasificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClasificacion.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClasificacion.Location = new Point(45, 68);
            dgvClasificacion.Margin = new Padding(2);
            dgvClasificacion.Name = "dgvClasificacion";
            dgvClasificacion.ReadOnly = true;
            dgvClasificacion.RowHeadersWidth = 62;
            dgvClasificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificacion.Size = new Size(1151, 314);
            dgvClasificacion.TabIndex = 1;
            dgvClasificacion.SelectionChanged += dgvClasificacion_SelectionChanged;
            // 
            // lbidClasificacion
            // 
            lbidClasificacion.AutoSize = true;
            lbidClasificacion.Location = new Point(119, 435);
            lbidClasificacion.Margin = new Padding(4, 0, 4, 0);
            lbidClasificacion.Name = "lbidClasificacion";
            lbidClasificacion.Size = new Size(140, 25);
            lbidClasificacion.TabIndex = 2;
            lbidClasificacion.Text = "ID Clasificación: ";
            // 
            // lbclave
            // 
            lbclave.AutoSize = true;
            lbclave.Location = new Point(196, 504);
            lbclave.Margin = new Padding(4, 0, 4, 0);
            lbclave.Name = "lbclave";
            lbclave.Size = new Size(63, 25);
            lbclave.TabIndex = 3;
            lbclave.Text = "Clave: ";
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(585, 440);
            lbdescripcion.Margin = new Padding(4, 0, 4, 0);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(113, 25);
            lbdescripcion.TabIndex = 5;
            lbdescripcion.Text = "Descripción: ";
            // 
            // lbfechaHoraCreacion
            // 
            lbfechaHoraCreacion.AutoSize = true;
            lbfechaHoraCreacion.Location = new Point(455, 504);
            lbfechaHoraCreacion.Margin = new Padding(4, 0, 4, 0);
            lbfechaHoraCreacion.Name = "lbfechaHoraCreacion";
            lbfechaHoraCreacion.Size = new Size(237, 25);
            lbfechaHoraCreacion.TabIndex = 6;
            lbfechaHoraCreacion.Text = "Fecha y hora de la Creación: ";
            // 
            // txtidClasificacion
            // 
            txtidClasificacion.Location = new Point(274, 431);
            txtidClasificacion.Margin = new Padding(4);
            txtidClasificacion.Name = "txtidClasificacion";
            txtidClasificacion.ReadOnly = true;
            txtidClasificacion.Size = new Size(155, 31);
            txtidClasificacion.TabIndex = 7;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(0, 0);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(100, 31);
            txtclave.TabIndex = 0;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(0, 0);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(100, 31);
            txtdescripcion.TabIndex = 0;
            // 
            // dateTimePickerFechaCreacion
            // 
            dateTimePickerFechaCreacion.Enabled = false;
            dateTimePickerFechaCreacion.Location = new Point(710, 504);
            dateTimePickerFechaCreacion.Margin = new Padding(4);
            dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            dateTimePickerFechaCreacion.Size = new Size(370, 31);
            dateTimePickerFechaCreacion.TabIndex = 8;
            // 
            // txtClaveClasif
            // 
            txtClaveClasif.Enabled = false;
            txtClaveClasif.Location = new Point(279, 503);
            txtClaveClasif.Name = "txtClaveClasif";
            txtClaveClasif.Size = new Size(150, 31);
            txtClaveClasif.TabIndex = 11;
            // 
            // txtDescrip
            // 
            txtDescrip.Enabled = false;
            txtDescrip.Location = new Point(710, 440);
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(370, 31);
            txtDescrip.TabIndex = 12;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 718);
            Controls.Add(txtDescrip);
            Controls.Add(txtClaveClasif);
            Controls.Add(dateTimePickerFechaCreacion);
            Controls.Add(txtidClasificacion);
            Controls.Add(lbfechaHoraCreacion);
            Controls.Add(lbdescripcion);
            Controls.Add(lbclave);
            Controls.Add(lbidClasificacion);
            Controls.Add(dgvClasificacion);
            Controls.Add(toolStrip1);
            Margin = new Padding(2);
            Name = "Clasificacion";
            Text = "Clasificacion";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel btnNuevo;
        private ToolStripLabel btnEditar;
        private ToolStripLabel btnEliminar;
        private ToolStripLabel btnGuardar;
        private ToolStripLabel btnCancelar;
        private ToolStripLabel btnObtener;
        private ToolStripLabel btnSalir;
        private DataGridView dgvClasificacion;
        private Label lbidClasificacion;
        private Label lbclave;
        private Label lbdescripcion;
        private Label lbfechaHoraCreacion;
        private TextBox txtidClasificacion;
        private ComboBox comboBox2;
        private TextBox txtclave;
        private TextBox txtdescripcion;
        private DateTimePicker dateTimePickerFechaCreacion;
        private TextBox txtClaveClasif;
        private TextBox txtDescrip;
    }
}