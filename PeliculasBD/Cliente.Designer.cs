namespace PeliculasBD
{
    partial class Cliente
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
            dgvCliente = new DataGridView();
            cmbCiudad = new ComboBox();
            txtCorreo = new TextBox();
            txtCelular = new TextBox();
            txtNombreCliente = new TextBox();
            txtIDCliente = new TextBox();
            lbCorreo = new Label();
            lbNombreCliente = new Label();
            lbCelular = new Label();
            lbCiudad = new Label();
            lbIDCliente = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1240, 30);
            toolStrip1.TabIndex = 3;
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
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(22, 56);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(1176, 356);
            dgvCliente.TabIndex = 19;
            dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
            // 
            // cmbCiudad
            // 
            cmbCiudad.Enabled = false;
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(797, 517);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(182, 33);
            cmbCiudad.TabIndex = 46;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(797, 454);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(182, 31);
            txtCorreo.TabIndex = 45;
            // 
            // txtCelular
            // 
            txtCelular.Enabled = false;
            txtCelular.Location = new Point(298, 564);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(191, 31);
            txtCelular.TabIndex = 44;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(298, 506);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(191, 31);
            txtNombreCliente.TabIndex = 43;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(298, 448);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(191, 31);
            txtIDCliente.TabIndex = 42;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(721, 458);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(70, 25);
            lbCorreo.TabIndex = 41;
            lbCorreo.Text = "Correo:";
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Location = new Point(152, 506);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(140, 25);
            lbNombreCliente.TabIndex = 40;
            lbNombreCliente.Text = "Nombre Cliente:";
            // 
            // lbCelular
            // 
            lbCelular.AutoSize = true;
            lbCelular.Location = new Point(223, 564);
            lbCelular.Name = "lbCelular";
            lbCelular.Size = new Size(69, 25);
            lbCelular.TabIndex = 39;
            lbCelular.Text = "Celular:";
            // 
            // lbCiudad
            // 
            lbCiudad.AutoSize = true;
            lbCiudad.Location = new Point(719, 520);
            lbCiudad.Name = "lbCiudad";
            lbCiudad.Size = new Size(72, 25);
            lbCiudad.TabIndex = 38;
            lbCiudad.Text = "Ciudad:";
            // 
            // lbIDCliente
            // 
            lbIDCliente.AutoSize = true;
            lbIDCliente.Location = new Point(200, 448);
            lbIDCliente.Name = "lbIDCliente";
            lbIDCliente.Size = new Size(92, 25);
            lbIDCliente.TabIndex = 37;
            lbIDCliente.Text = "ID Cliente:";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 639);
            Controls.Add(cmbCiudad);
            Controls.Add(txtCorreo);
            Controls.Add(txtCelular);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIDCliente);
            Controls.Add(lbCorreo);
            Controls.Add(lbNombreCliente);
            Controls.Add(lbCelular);
            Controls.Add(lbCiudad);
            Controls.Add(lbIDCliente);
            Controls.Add(dgvCliente);
            Controls.Add(toolStrip1);
            Name = "Cliente";
            Text = "Cliente";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
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
        private DataGridView dgvCliente;
        private ComboBox cmbCiudad;
        private TextBox txtCorreo;
        private TextBox txtCelular;
        private TextBox txtNombreCliente;
        private TextBox txtIDCliente;
        private Label lbCorreo;
        private Label lbNombreCliente;
        private Label lbCelular;
        private Label lbCiudad;
        private Label lbIDCliente;
    }
}