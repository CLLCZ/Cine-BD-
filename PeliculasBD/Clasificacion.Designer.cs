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
            txtidClasificacion = new TextBox();
            cbdescripcion = new ComboBox();
            cbclave = new ComboBox();
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
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            lbclave.Location = new Point(410, 353);
            lbclave.Name = "lbclave";
            lbclave.Size = new Size(52, 20);
            lbclave.TabIndex = 3;
            lbclave.Text = "Clave: ";
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(413, 395);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(94, 20);
            lbdescripcion.TabIndex = 5;
            lbdescripcion.Text = "Descripción: ";
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
            cbdescripcion.FormattingEnabled = true;
            cbdescripcion.Items.AddRange(new object[] { "Todos los públicos pueden ver, aunque esta clasificación va dirigida a un público preescolar", "Apto para todo público, sugerido a mayores de 7 años", "Para mayores de 12 años, menores requieren supervisión", "Para mayores de 15 años, menores requieren supervisión", "Sólo para mayores de 18 años ", "Exclusivamente adultos: restringido a mayores de 18 años " });
            cbdescripcion.Location = new Point(524, 391);
            cbdescripcion.Name = "cbdescripcion";
            cbdescripcion.Size = new Size(298, 28);
            cbdescripcion.TabIndex = 12;
            // 
            // cbclave
            // 
            cbclave.FormattingEnabled = true;
            cbclave.Items.AddRange(new object[] { "AA", "A", "B", "B15", "C", "D" });
            cbclave.Location = new Point(524, 345);
            cbclave.Name = "cbclave";
            cbclave.Size = new Size(151, 28);
            cbclave.TabIndex = 13;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 574);
            Controls.Add(cbclave);
            Controls.Add(cbdescripcion);
            Controls.Add(txtidClasificacion);
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
        private TextBox txtidClasificacion;
        private ComboBox cbdescripcion;
        private ComboBox cbclave;
    }
}