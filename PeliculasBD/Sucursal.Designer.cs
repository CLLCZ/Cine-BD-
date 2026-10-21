namespace PeliculasBD
{
    partial class Sucursal
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
            dgvSucursal = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripLabel();
            btnEditar = new ToolStripLabel();
            btnEliminar = new ToolStripLabel();
            btnGuardar = new ToolStripLabel();
            btnCancelar = new ToolStripLabel();
            btnObtener = new ToolStripLabel();
            btnSalir = new ToolStripLabel();
            cmbCiudad = new ComboBox();
            txtDireccion = new TextBox();
            txtNombreSucursal = new TextBox();
            txtIdSucursal = new TextBox();
            lbCiudad = new Label();
            lbDireccion = new Label();
            lbNombreSucursal = new Label();
            labelIdSucursal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSucursal
            // 
            dgvSucursal.AllowUserToAddRows = false;
            dgvSucursal.AllowUserToDeleteRows = false;
            dgvSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursal.Location = new Point(43, 53);
            dgvSucursal.Name = "dgvSucursal";
            dgvSucursal.ReadOnly = true;
            dgvSucursal.RowHeadersWidth = 62;
            dgvSucursal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursal.Size = new Size(1004, 365);
            dgvSucursal.TabIndex = 0;
            dgvSucursal.SelectionChanged += dgvSucursal_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 30);
            toolStrip1.TabIndex = 1;
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
            // cmbCiudad
            // 
            cmbCiudad.Enabled = false;
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(724, 539);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(182, 33);
            cmbCiudad.TabIndex = 19;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(724, 474);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 18;
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Enabled = false;
            txtNombreSucursal.Location = new Point(265, 541);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(150, 31);
            txtNombreSucursal.TabIndex = 17;
            // 
            // txtIdSucursal
            // 
            txtIdSucursal.Location = new Point(265, 474);
            txtIdSucursal.Name = "txtIdSucursal";
            txtIdSucursal.ReadOnly = true;
            txtIdSucursal.Size = new Size(150, 31);
            txtIdSucursal.TabIndex = 16;
            // 
            // lbCiudad
            // 
            lbCiudad.AutoSize = true;
            lbCiudad.Location = new Point(646, 541);
            lbCiudad.Name = "lbCiudad";
            lbCiudad.Size = new Size(72, 25);
            lbCiudad.TabIndex = 15;
            lbCiudad.Text = "Ciudad:";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(629, 474);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(89, 25);
            lbDireccion.TabIndex = 14;
            lbDireccion.Text = "Dirección:";
            // 
            // lbNombreSucursal
            // 
            lbNombreSucursal.AutoSize = true;
            lbNombreSucursal.Location = new Point(107, 541);
            lbNombreSucursal.Name = "lbNombreSucursal";
            lbNombreSucursal.Size = new Size(152, 25);
            lbNombreSucursal.TabIndex = 13;
            lbNombreSucursal.Text = "Nombre Sucursal:";
            // 
            // labelIdSucursal
            // 
            labelIdSucursal.AutoSize = true;
            labelIdSucursal.Location = new Point(162, 474);
            labelIdSucursal.Name = "labelIdSucursal";
            labelIdSucursal.Size = new Size(97, 25);
            labelIdSucursal.TabIndex = 12;
            labelIdSucursal.Text = "IdSucursal:";
            // 
            // Sucursal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 667);
            Controls.Add(cmbCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreSucursal);
            Controls.Add(txtIdSucursal);
            Controls.Add(lbCiudad);
            Controls.Add(lbDireccion);
            Controls.Add(lbNombreSucursal);
            Controls.Add(labelIdSucursal);
            Controls.Add(toolStrip1);
            Controls.Add(dgvSucursal);
            Name = "Sucursal";
            Text = "Sucursal";
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSucursal;
        private ToolStrip toolStrip1;
        private ToolStripLabel btnNuevo;
        private ToolStripLabel btnEditar;
        private ToolStripLabel btnEliminar;
        private ToolStripLabel btnGuardar;
        private ToolStripLabel btnCancelar;
        private ToolStripLabel btnObtener;
        private ToolStripLabel btnSalir;
        private ComboBox cmbCiudad;
        private TextBox txtDireccion;
        private TextBox txtNombreSucursal;
        private TextBox txtIdSucursal;
        private Label lbCiudad;
        private Label lbDireccion;
        private Label lbNombreSucursal;
        private Label labelIdSucursal;
    }
}