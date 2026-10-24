namespace PeliculasBD
{
    partial class Ciudad
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
            dgvCiudad = new DataGridView();
            cmbEstado = new ComboBox();
            txtClave = new TextBox();
            txtSiglas = new TextBox();
            txtNomCiudad = new TextBox();
            txtIDCiudad = new TextBox();
            lbClaveCiudad = new Label();
            lbNombreCiudad = new Label();
            lbSiglasCiudad = new Label();
            lbEstado = new Label();
            lbIDCiudad = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1143, 30);
            toolStrip1.TabIndex = 2;
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
            // dgvCiudad
            // 
            dgvCiudad.AllowUserToAddRows = false;
            dgvCiudad.AllowUserToDeleteRows = false;
            dgvCiudad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCiudad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudad.Location = new Point(31, 51);
            dgvCiudad.Name = "dgvCiudad";
            dgvCiudad.ReadOnly = true;
            dgvCiudad.RowHeadersWidth = 62;
            dgvCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudad.Size = new Size(1072, 366);
            dgvCiudad.TabIndex = 18;
            dgvCiudad.SelectionChanged += dgvCiudad_SelectionChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.Enabled = false;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(767, 535);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 46;
            // 
            // txtClave
            // 
            txtClave.Enabled = false;
            txtClave.Location = new Point(767, 472);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(182, 31);
            txtClave.TabIndex = 45;
            // 
            // txtSiglas
            // 
            txtSiglas.Enabled = false;
            txtSiglas.Location = new Point(271, 582);
            txtSiglas.Name = "txtSiglas";
            txtSiglas.Size = new Size(191, 31);
            txtSiglas.TabIndex = 44;
            // 
            // txtNomCiudad
            // 
            txtNomCiudad.Enabled = false;
            txtNomCiudad.Location = new Point(271, 524);
            txtNomCiudad.Name = "txtNomCiudad";
            txtNomCiudad.Size = new Size(191, 31);
            txtNomCiudad.TabIndex = 43;
            // 
            // txtIDCiudad
            // 
            txtIDCiudad.Location = new Point(271, 466);
            txtIDCiudad.Name = "txtIDCiudad";
            txtIDCiudad.ReadOnly = true;
            txtIDCiudad.Size = new Size(191, 31);
            txtIDCiudad.TabIndex = 42;
            // 
            // lbClaveCiudad
            // 
            lbClaveCiudad.AutoSize = true;
            lbClaveCiudad.Location = new Point(617, 475);
            lbClaveCiudad.Name = "lbClaveCiudad";
            lbClaveCiudad.Size = new Size(144, 25);
            lbClaveCiudad.TabIndex = 41;
            lbClaveCiudad.Text = "Clave de Ciudad:";
            // 
            // lbNombreCiudad
            // 
            lbNombreCiudad.AutoSize = true;
            lbNombreCiudad.Location = new Point(98, 524);
            lbNombreCiudad.Name = "lbNombreCiudad";
            lbNombreCiudad.Size = new Size(168, 25);
            lbNombreCiudad.TabIndex = 40;
            lbNombreCiudad.Text = "Nombre de Ciudad:";
            // 
            // lbSiglasCiudad
            // 
            lbSiglasCiudad.AutoSize = true;
            lbSiglasCiudad.Location = new Point(117, 582);
            lbSiglasCiudad.Name = "lbSiglasCiudad";
            lbSiglasCiudad.Size = new Size(148, 25);
            lbSiglasCiudad.TabIndex = 39;
            lbSiglasCiudad.Text = "Siglas de Ciudad:";
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Location = new Point(691, 535);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(70, 25);
            lbEstado.TabIndex = 38;
            lbEstado.Text = "Estado:";
            // 
            // lbIDCiudad
            // 
            lbIDCiudad.AutoSize = true;
            lbIDCiudad.Location = new Point(170, 466);
            lbIDCiudad.Name = "lbIDCiudad";
            lbIDCiudad.Size = new Size(95, 25);
            lbIDCiudad.TabIndex = 37;
            lbIDCiudad.Text = "ID Ciudad:";
            // 
            // Ciudad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 646);
            Controls.Add(cmbEstado);
            Controls.Add(txtClave);
            Controls.Add(txtSiglas);
            Controls.Add(txtNomCiudad);
            Controls.Add(txtIDCiudad);
            Controls.Add(lbClaveCiudad);
            Controls.Add(lbNombreCiudad);
            Controls.Add(lbSiglasCiudad);
            Controls.Add(lbEstado);
            Controls.Add(lbIDCiudad);
            Controls.Add(dgvCiudad);
            Controls.Add(toolStrip1);
            Name = "Ciudad";
            Text = "Ciudad";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).EndInit();
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
        private DataGridView dgvCiudad;
        private ComboBox cmbEstado;
        private TextBox txtClave;
        private TextBox txtSiglas;
        private TextBox txtNomCiudad;
        private TextBox txtIDCiudad;
        private Label lbClaveCiudad;
        private Label lbNombreCiudad;
        private Label lbSiglasCiudad;
        private Label lbEstado;
        private Label lbIDCiudad;
    }
}