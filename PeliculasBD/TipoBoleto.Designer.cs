namespace PeliculasBD
{
    partial class TipoBoleto
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
            dgvTipoBoleto = new DataGridView();
            txtPrecio = new TextBox();
            labelPrecio = new Label();
            txtDescripcion = new TextBox();
            txtClave = new TextBox();
            txtidTipoBoleto = new TextBox();
            lbdescripcion = new Label();
            lbclave = new Label();
            lbidTipoBoleto = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoBoleto).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1151, 30);
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
            // dgvTipoBoleto
            // 
            dgvTipoBoleto.AllowUserToAddRows = false;
            dgvTipoBoleto.AllowUserToDeleteRows = false;
            dgvTipoBoleto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoBoleto.Location = new Point(39, 54);
            dgvTipoBoleto.Name = "dgvTipoBoleto";
            dgvTipoBoleto.ReadOnly = true;
            dgvTipoBoleto.RowHeadersWidth = 62;
            dgvTipoBoleto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoBoleto.Size = new Size(1076, 376);
            dgvTipoBoleto.TabIndex = 5;
            dgvTipoBoleto.SelectionChanged += dgvTipoBoleto_SelectionChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(292, 601);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 25;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(214, 607);
            labelPrecio.Margin = new Padding(4, 0, 4, 0);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(69, 25);
            labelPrecio.TabIndex = 24;
            labelPrecio.Text = "Precio: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(602, 508);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(395, 92);
            txtDescripcion.TabIndex = 23;
            // 
            // txtClave
            // 
            txtClave.Enabled = false;
            txtClave.Location = new Point(292, 529);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 22;
            // 
            // txtidTipoBoleto
            // 
            txtidTipoBoleto.Location = new Point(292, 460);
            txtidTipoBoleto.Margin = new Padding(4);
            txtidTipoBoleto.Name = "txtidTipoBoleto";
            txtidTipoBoleto.ReadOnly = true;
            txtidTipoBoleto.Size = new Size(155, 31);
            txtidTipoBoleto.TabIndex = 21;
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(602, 480);
            lbdescripcion.Margin = new Padding(4, 0, 4, 0);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(113, 25);
            lbdescripcion.TabIndex = 20;
            lbdescripcion.Text = "Descripción: ";
            // 
            // lbclave
            // 
            lbclave.AutoSize = true;
            lbclave.Location = new Point(214, 535);
            lbclave.Margin = new Padding(4, 0, 4, 0);
            lbclave.Name = "lbclave";
            lbclave.Size = new Size(63, 25);
            lbclave.TabIndex = 19;
            lbclave.Text = "Clave: ";
            // 
            // lbidTipoBoleto
            // 
            lbidTipoBoleto.AutoSize = true;
            lbidTipoBoleto.Location = new Point(137, 464);
            lbidTipoBoleto.Margin = new Padding(4, 0, 4, 0);
            lbidTipoBoleto.Name = "lbidTipoBoleto";
            lbidTipoBoleto.Size = new Size(140, 25);
            lbidTipoBoleto.TabIndex = 18;
            lbidTipoBoleto.Text = "ID Clasificación: ";
            // 
            // TipoBoleto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 661);
            Controls.Add(txtPrecio);
            Controls.Add(labelPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtClave);
            Controls.Add(txtidTipoBoleto);
            Controls.Add(lbdescripcion);
            Controls.Add(lbclave);
            Controls.Add(lbidTipoBoleto);
            Controls.Add(dgvTipoBoleto);
            Controls.Add(toolStrip1);
            Name = "TipoBoleto";
            Text = "TipoBoleto";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoBoleto).EndInit();
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
        private DataGridView dgvTipoBoleto;
        private TextBox txtPrecio;
        private Label labelPrecio;
        private TextBox txtDescripcion;
        private TextBox txtClave;
        private TextBox txtidTipoBoleto;
        private Label lbdescripcion;
        private Label lbclave;
        private Label lbidTipoBoleto;
    }
}