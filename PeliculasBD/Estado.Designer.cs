namespace PeliculasBD
{
    partial class Estado
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
            dgvEstado = new DataGridView();
            txtSiglas = new TextBox();
            txtClaveEst = new TextBox();
            txtNombreEst = new TextBox();
            txtIDEstado = new TextBox();
            lbSiglas = new Label();
            lbNombreEst = new Label();
            lbClave = new Label();
            lbIDEstado = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstado).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1106, 30);
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
            // dgvEstado
            // 
            dgvEstado.AllowUserToAddRows = false;
            dgvEstado.AllowUserToDeleteRows = false;
            dgvEstado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstado.Location = new Point(27, 52);
            dgvEstado.Name = "dgvEstado";
            dgvEstado.ReadOnly = true;
            dgvEstado.RowHeadersWidth = 62;
            dgvEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstado.Size = new Size(1054, 381);
            dgvEstado.TabIndex = 18;
            dgvEstado.SelectionChanged += dgvEstado_SelectionChanged;
            // 
            // txtSiglas
            // 
            txtSiglas.Enabled = false;
            txtSiglas.Location = new Point(748, 492);
            txtSiglas.Name = "txtSiglas";
            txtSiglas.Size = new Size(182, 31);
            txtSiglas.TabIndex = 43;
            // 
            // txtClaveEst
            // 
            txtClaveEst.Enabled = false;
            txtClaveEst.Location = new Point(748, 541);
            txtClaveEst.Name = "txtClaveEst";
            txtClaveEst.Size = new Size(182, 31);
            txtClaveEst.TabIndex = 42;
            // 
            // txtNombreEst
            // 
            txtNombreEst.Enabled = false;
            txtNombreEst.Location = new Point(267, 548);
            txtNombreEst.Name = "txtNombreEst";
            txtNombreEst.Size = new Size(191, 31);
            txtNombreEst.TabIndex = 41;
            // 
            // txtIDEstado
            // 
            txtIDEstado.Location = new Point(267, 490);
            txtIDEstado.Name = "txtIDEstado";
            txtIDEstado.ReadOnly = true;
            txtIDEstado.Size = new Size(191, 31);
            txtIDEstado.TabIndex = 40;
            // 
            // lbSiglas
            // 
            lbSiglas.AutoSize = true;
            lbSiglas.Location = new Point(592, 492);
            lbSiglas.Name = "lbSiglas";
            lbSiglas.Size = new Size(150, 25);
            lbSiglas.TabIndex = 39;
            lbSiglas.Text = "Siglas del Estado:";
            // 
            // lbNombreEst
            // 
            lbNombreEst.AutoSize = true;
            lbNombreEst.Location = new Point(120, 548);
            lbNombreEst.Name = "lbNombreEst";
            lbNombreEst.Size = new Size(141, 25);
            lbNombreEst.TabIndex = 38;
            lbNombreEst.Text = "Nombre Estado:";
            // 
            // lbClave
            // 
            lbClave.AutoSize = true;
            lbClave.Location = new Point(596, 544);
            lbClave.Name = "lbClave";
            lbClave.Size = new Size(146, 25);
            lbClave.TabIndex = 37;
            lbClave.Text = "Clave del Estado:";
            // 
            // lbIDEstado
            // 
            lbIDEstado.AutoSize = true;
            lbIDEstado.Location = new Point(166, 490);
            lbIDEstado.Name = "lbIDEstado";
            lbIDEstado.Size = new Size(93, 25);
            lbIDEstado.TabIndex = 36;
            lbIDEstado.Text = "ID Estado:";
            // 
            // Estado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 647);
            Controls.Add(txtSiglas);
            Controls.Add(txtClaveEst);
            Controls.Add(txtNombreEst);
            Controls.Add(txtIDEstado);
            Controls.Add(lbSiglas);
            Controls.Add(lbNombreEst);
            Controls.Add(lbClave);
            Controls.Add(lbIDEstado);
            Controls.Add(dgvEstado);
            Controls.Add(toolStrip1);
            Name = "Estado";
            Text = "Estado";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstado).EndInit();
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
        private DataGridView dgvEstado;
        private TextBox txtSiglas;
        private TextBox txtClaveEst;
        private TextBox txtNombreEst;
        private TextBox txtIDEstado;
        private Label lbSiglas;
        private Label lbNombreEst;
        private Label lbClave;
        private Label lbIDEstado;
    }
}