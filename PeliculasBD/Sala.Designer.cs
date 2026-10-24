namespace PeliculasBD
{
    partial class Sala
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
            dgvSala = new DataGridView();
            cmbSucursal = new ComboBox();
            txtAsientos = new TextBox();
            txtTipoSala = new TextBox();
            txtNumSala = new TextBox();
            txtIDSala = new TextBox();
            lbCantidadAsientos = new Label();
            lbNumeroSala = new Label();
            lbTipoSala = new Label();
            lbSucursal = new Label();
            lbIDSala = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSala).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1154, 30);
            toolStrip1.TabIndex = 4;
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
            // dgvSala
            // 
            dgvSala.AllowUserToAddRows = false;
            dgvSala.AllowUserToDeleteRows = false;
            dgvSala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSala.Location = new Point(23, 53);
            dgvSala.Name = "dgvSala";
            dgvSala.ReadOnly = true;
            dgvSala.RowHeadersWidth = 62;
            dgvSala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSala.Size = new Size(1085, 382);
            dgvSala.TabIndex = 17;
            dgvSala.SelectionChanged += dgvSala_SelectionChanged;
            // 
            // cmbSucursal
            // 
            cmbSucursal.Enabled = false;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(772, 537);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(182, 33);
            cmbSucursal.TabIndex = 36;
            // 
            // txtAsientos
            // 
            txtAsientos.Enabled = false;
            txtAsientos.Location = new Point(772, 474);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(182, 31);
            txtAsientos.TabIndex = 35;
            // 
            // txtTipoSala
            // 
            txtTipoSala.Enabled = false;
            txtTipoSala.Location = new Point(252, 584);
            txtTipoSala.Name = "txtTipoSala";
            txtTipoSala.Size = new Size(191, 31);
            txtTipoSala.TabIndex = 34;
            // 
            // txtNumSala
            // 
            txtNumSala.Enabled = false;
            txtNumSala.Location = new Point(252, 526);
            txtNumSala.Name = "txtNumSala";
            txtNumSala.Size = new Size(191, 31);
            txtNumSala.TabIndex = 33;
            // 
            // txtIDSala
            // 
            txtIDSala.Location = new Point(252, 468);
            txtIDSala.Name = "txtIDSala";
            txtIDSala.ReadOnly = true;
            txtIDSala.Size = new Size(191, 31);
            txtIDSala.TabIndex = 32;
            // 
            // lbCantidadAsientos
            // 
            lbCantidadAsientos.AutoSize = true;
            lbCantidadAsientos.Location = new Point(581, 474);
            lbCantidadAsientos.Name = "lbCantidadAsientos";
            lbCantidadAsientos.Size = new Size(185, 25);
            lbCantidadAsientos.TabIndex = 31;
            lbCantidadAsientos.Text = "Cantidad de Asientos:";
            // 
            // lbNumeroSala
            // 
            lbNumeroSala.AutoSize = true;
            lbNumeroSala.Location = new Point(103, 526);
            lbNumeroSala.Name = "lbNumeroSala";
            lbNumeroSala.Size = new Size(143, 25);
            lbNumeroSala.TabIndex = 30;
            lbNumeroSala.Text = "Número de Sala:";
            // 
            // lbTipoSala
            // 
            lbTipoSala.AutoSize = true;
            lbTipoSala.Location = new Point(133, 584);
            lbTipoSala.Name = "lbTipoSala";
            lbTipoSala.Size = new Size(113, 25);
            lbTipoSala.TabIndex = 29;
            lbTipoSala.Text = "Tipo de Sala:";
            // 
            // lbSucursal
            // 
            lbSucursal.AutoSize = true;
            lbSucursal.Location = new Point(685, 537);
            lbSucursal.Name = "lbSucursal";
            lbSucursal.Size = new Size(81, 25);
            lbSucursal.TabIndex = 28;
            lbSucursal.Text = "Sucursal:";
            // 
            // lbIDSala
            // 
            lbIDSala.AutoSize = true;
            lbIDSala.Location = new Point(175, 468);
            lbIDSala.Name = "lbIDSala";
            lbIDSala.Size = new Size(71, 25);
            lbIDSala.TabIndex = 27;
            lbIDSala.Text = "ID Sala:";
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 647);
            Controls.Add(cmbSucursal);
            Controls.Add(txtAsientos);
            Controls.Add(txtTipoSala);
            Controls.Add(txtNumSala);
            Controls.Add(txtIDSala);
            Controls.Add(lbCantidadAsientos);
            Controls.Add(lbNumeroSala);
            Controls.Add(lbTipoSala);
            Controls.Add(lbSucursal);
            Controls.Add(lbIDSala);
            Controls.Add(dgvSala);
            Controls.Add(toolStrip1);
            Name = "Sala";
            Text = "Sala";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSala).EndInit();
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
        private DataGridView dgvSala;
        private ComboBox cmbSucursal;
        private TextBox txtAsientos;
        private TextBox txtTipoSala;
        private TextBox txtNumSala;
        private TextBox txtIDSala;
        private Label lbCantidadAsientos;
        private Label lbNumeroSala;
        private Label lbTipoSala;
        private Label lbSucursal;
        private Label lbIDSala;
    }
}