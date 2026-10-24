namespace PeliculasBD
{
    partial class Venta
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
            dgvVenta = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripLabel();
            btnEditar = new ToolStripLabel();
            btnEliminar = new ToolStripLabel();
            btnGuardar = new ToolStripLabel();
            btnCancelar = new ToolStripLabel();
            btnObtener = new ToolStripLabel();
            btnSalir = new ToolStripLabel();
            lbidVenta = new Label();
            lbidCliente = new Label();
            lbidFuncion = new Label();
            lbidTipoBoleto = new Label();
            lbPrecio = new Label();
            txtidVenta = new TextBox();
            txtPrecio = new TextBox();
            cbCliente = new ComboBox();
            cbFuncion = new ComboBox();
            cbTipoBoleto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.AllowUserToDeleteRows = false;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(15, 52);
            dgvVenta.Margin = new Padding(4);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVenta.Size = new Size(818, 235);
            dgvVenta.TabIndex = 0;
            dgvVenta.SelectionChanged += dgvVenta_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 30);
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
            // lbidVenta
            // 
            lbidVenta.AutoSize = true;
            lbidVenta.Location = new Point(48, 335);
            lbidVenta.Margin = new Padding(4, 0, 4, 0);
            lbidVenta.Name = "lbidVenta";
            lbidVenta.Size = new Size(88, 25);
            lbidVenta.TabIndex = 4;
            lbidVenta.Text = "ID Venta: ";
            // 
            // lbidCliente
            // 
            lbidCliente.AutoSize = true;
            lbidCliente.Location = new Point(48, 389);
            lbidCliente.Margin = new Padding(4, 0, 4, 0);
            lbidCliente.Name = "lbidCliente";
            lbidCliente.Size = new Size(74, 25);
            lbidCliente.TabIndex = 5;
            lbidCliente.Text = "Cliente: ";
            // 
            // lbidFuncion
            // 
            lbidFuncion.AutoSize = true;
            lbidFuncion.Location = new Point(48, 439);
            lbidFuncion.Margin = new Padding(4, 0, 4, 0);
            lbidFuncion.Name = "lbidFuncion";
            lbidFuncion.Size = new Size(83, 25);
            lbidFuncion.TabIndex = 6;
            lbidFuncion.Text = "Funcion: ";
            // 
            // lbidTipoBoleto
            // 
            lbidTipoBoleto.AutoSize = true;
            lbidTipoBoleto.Location = new Point(416, 361);
            lbidTipoBoleto.Margin = new Padding(4, 0, 4, 0);
            lbidTipoBoleto.Name = "lbidTipoBoleto";
            lbidTipoBoleto.Size = new Size(112, 25);
            lbidTipoBoleto.TabIndex = 7;
            lbidTipoBoleto.Text = "Tipo Boleto: ";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(486, 419);
            lbPrecio.Margin = new Padding(4, 0, 4, 0);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(69, 25);
            lbPrecio.TabIndex = 8;
            lbPrecio.Text = "Precio: ";
            // 
            // txtidVenta
            // 
            txtidVenta.Location = new Point(162, 335);
            txtidVenta.Margin = new Padding(4);
            txtidVenta.Name = "txtidVenta";
            txtidVenta.ReadOnly = true;
            txtidVenta.Size = new Size(208, 31);
            txtidVenta.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(565, 419);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(213, 31);
            txtPrecio.TabIndex = 13;
            // 
            // cbCliente
            // 
            cbCliente.Enabled = false;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(162, 385);
            cbCliente.Margin = new Padding(4);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(208, 33);
            cbCliente.TabIndex = 14;
            // 
            // cbFuncion
            // 
            cbFuncion.Enabled = false;
            cbFuncion.FormattingEnabled = true;
            cbFuncion.Location = new Point(162, 435);
            cbFuncion.Margin = new Padding(4);
            cbFuncion.Name = "cbFuncion";
            cbFuncion.Size = new Size(208, 33);
            cbFuncion.TabIndex = 15;
            // 
            // cbTipoBoleto
            // 
            cbTipoBoleto.Enabled = false;
            cbTipoBoleto.FormattingEnabled = true;
            cbTipoBoleto.Location = new Point(565, 358);
            cbTipoBoleto.Margin = new Padding(4);
            cbTipoBoleto.Name = "cbTipoBoleto";
            cbTipoBoleto.Size = new Size(213, 33);
            cbTipoBoleto.TabIndex = 16;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(cbTipoBoleto);
            Controls.Add(cbFuncion);
            Controls.Add(cbCliente);
            Controls.Add(txtPrecio);
            Controls.Add(txtidVenta);
            Controls.Add(lbPrecio);
            Controls.Add(lbidTipoBoleto);
            Controls.Add(lbidFuncion);
            Controls.Add(lbidCliente);
            Controls.Add(lbidVenta);
            Controls.Add(toolStrip1);
            Controls.Add(dgvVenta);
            Margin = new Padding(4);
            Name = "Venta";
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVenta;
        private ToolStrip toolStrip1;
        private ToolStripLabel btnNuevo;
        private ToolStripLabel btnEditar;
        private ToolStripLabel btnEliminar;
        private ToolStripLabel btnGuardar;
        private ToolStripLabel btnCancelar;
        private ToolStripLabel btnObtener;
        private ToolStripLabel btnSalir;
        private Label lbidVenta;
        private Label lbidCliente;
        private Label lbidFuncion;
        private Label lbidTipoBoleto;
        private Label lbPrecio;
        private TextBox txtidVenta;
        private TextBox txtPrecio;
        private ComboBox cbCliente;
        private ComboBox cbFuncion;
        private ComboBox cbTipoBoleto;
    }
}