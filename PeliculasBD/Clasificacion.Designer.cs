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
            cbdescripcion = new ComboBox();
            cbclave = new ComboBox();
            txtclave = new TextBox();
            txtdescripcion = new TextBox();
            dateTimePickerFechaCreacion = new DateTimePicker();
            checkedListBoxHora = new CheckedListBox();
            checkedListBoxAMPM = new CheckedListBox();
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
            toolStrip1.Size = new Size(994, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(52, 22);
            btnNuevo.Text = "Nuevo";
            // 
            // btnEditar
            // 
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(48, 22);
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(63, 22);
            btnEliminar.Text = "Eliminar";
            // 
            // btnGuardar
            // 
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(62, 22);
            btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(66, 22);
            btnCancelar.Text = "Cancelar";
            // 
            // btnObtener
            // 
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(106, 22);
            btnObtener.Text = "Obtener Datos";
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(38, 22);
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
            dgvClasificacion.Location = new Point(36, 54);
            dgvClasificacion.Margin = new Padding(2);
            dgvClasificacion.Name = "dgvClasificacion";
            dgvClasificacion.ReadOnly = true;
            dgvClasificacion.RowHeadersWidth = 62;
            dgvClasificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificacion.Size = new Size(921, 251);
            dgvClasificacion.TabIndex = 1;
            // 
            // lbidClasificacion
            // 
            lbidClasificacion.AutoSize = true;
            lbidClasificacion.Location = new Point(95, 348);
            lbidClasificacion.Name = "lbidClasificacion";
            lbidClasificacion.Size = new Size(118, 20);
            lbidClasificacion.TabIndex = 2;
            lbidClasificacion.Text = "ID Clasificación: ";
            // 
            // lbclave
            // 
            lbclave.AutoSize = true;
            lbclave.Location = new Point(95, 405);
            lbclave.Name = "lbclave";
            lbclave.Size = new Size(52, 20);
            lbclave.TabIndex = 3;
            lbclave.Text = "Clave: ";
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(468, 352);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(94, 20);
            lbdescripcion.TabIndex = 5;
            lbdescripcion.Text = "Descripción: ";
            // 
            // lbfechaHoraCreacion
            // 
            lbfechaHoraCreacion.AutoSize = true;
            lbfechaHoraCreacion.Location = new Point(364, 403);
            lbfechaHoraCreacion.Name = "lbfechaHoraCreacion";
            lbfechaHoraCreacion.Size = new Size(198, 20);
            lbfechaHoraCreacion.TabIndex = 6;
            lbfechaHoraCreacion.Text = "Fecha y hora de la Creación: ";
            // 
            // txtidClasificacion
            // 
            txtidClasificacion.Location = new Point(219, 345);
            txtidClasificacion.Name = "txtidClasificacion";
            txtidClasificacion.Size = new Size(125, 27);
            txtidClasificacion.TabIndex = 7;
            // 
            // cbdescripcion
            // 
            cbdescripcion.Items.AddRange(new object[] { "Todos los públicos pueden ver, aunque esta clasificación va dirigida a un público más preescolar", "Apto para todo público, sugerido a mayores de 7 años", "Para mayores de 12 años, menores requieren supervisión.", "Para mayores de 15 años, menores requieren supervisión", "Sólo para mayores de 18 años", "Exclusivamente adultos: restringido a mayores de 18 años." });
            cbdescripcion.Location = new Point(568, 345);
            cbdescripcion.Name = "cbdescripcion";
            cbdescripcion.Size = new Size(275, 28);
            cbdescripcion.TabIndex = 0;
            // 
            // cbclave
            // 
            cbclave.Items.AddRange(new object[] { "AA", "A", "B", "B15", "C", "D" });
            cbclave.Location = new Point(163, 402);
            cbclave.Name = "cbclave";
            cbclave.Size = new Size(181, 28);
            cbclave.TabIndex = 0;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(0, 0);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(100, 27);
            txtclave.TabIndex = 0;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(0, 0);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(100, 27);
            txtdescripcion.TabIndex = 0;
            // 
            // dateTimePickerFechaCreacion
            // 
            dateTimePickerFechaCreacion.Location = new Point(568, 403);
            dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            dateTimePickerFechaCreacion.Size = new Size(297, 27);
            dateTimePickerFechaCreacion.TabIndex = 8;
            // 
            // checkedListBoxHora
            // 
            checkedListBoxHora.FormattingEnabled = true;
            checkedListBoxHora.Items.AddRange(new object[] { "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45" });
            checkedListBoxHora.Location = new Point(579, 448);
            checkedListBoxHora.Name = "checkedListBoxHora";
            checkedListBoxHora.Size = new Size(134, 114);
            checkedListBoxHora.TabIndex = 9;
            // 
            // checkedListBoxAMPM
            // 
            checkedListBoxAMPM.FormattingEnabled = true;
            checkedListBoxAMPM.Items.AddRange(new object[] { "AM", "PM" });
            checkedListBoxAMPM.Location = new Point(737, 475);
            checkedListBoxAMPM.Name = "checkedListBoxAMPM";
            checkedListBoxAMPM.Size = new Size(128, 48);
            checkedListBoxAMPM.TabIndex = 10;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 574);
            Controls.Add(checkedListBoxAMPM);
            Controls.Add(checkedListBoxHora);
            Controls.Add(dateTimePickerFechaCreacion);
            Controls.Add(cbdescripcion);
            Controls.Add(cbclave);
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
        private ComboBox cbdescripcion;
        private ComboBox comboBox2;
        private ComboBox cbclave;
        private TextBox txtclave;
        private TextBox txtdescripcion;
        private DateTimePicker dateTimePickerFechaCreacion;
        private CheckedListBox checkedListBoxHora;
        private CheckedListBox checkedListBoxAMPM;
    }
}