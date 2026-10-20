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
            txtclave = new TextBox();
            txtdescripcion = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            toolStrip1.Size = new Size(1248, 30);
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
            // 
            // btnEliminar
            // 
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(74, 25);
            btnEliminar.Text = "Eliminar";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 25);
            btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 25);
            btnCancelar.Text = "Cancelar";
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
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            lbclave.Location = new Point(196, 506);
            lbclave.Margin = new Padding(4, 0, 4, 0);
            lbclave.Name = "lbclave";
            lbclave.Size = new Size(63, 25);
            lbclave.TabIndex = 3;
            lbclave.Text = "Clave: ";
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(585, 435);
            lbdescripcion.Margin = new Padding(4, 0, 4, 0);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(113, 25);
            lbdescripcion.TabIndex = 5;
            lbdescripcion.Text = "Descripción: ";
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
            // cbdescripcion
            // 
            cbdescripcion.Location = new Point(0, 0);
            cbdescripcion.Name = "cbdescripcion";
            cbdescripcion.Size = new Size(121, 33);
            cbdescripcion.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(274, 500);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(585, 463);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 92);
            textBox2.TabIndex = 9;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 601);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private ComboBox comboBox2;
        private TextBox txtclave;
        private TextBox txtdescripcion;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}