namespace PeliculasBD
{
    partial class Pelicula
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
            dgvpelicula = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripLabel();
            btnEditar = new ToolStripLabel();
            btnEliminar = new ToolStripLabel();
            btnGuardar = new ToolStripLabel();
            btnCancelar = new ToolStripLabel();
            btnObtener = new ToolStripLabel();
            btnSalir = new ToolStripLabel();
            lbidGenero = new Label();
            lbduracion = new Label();
            lbnombrePelicula = new Label();
            lbidPelicula = new Label();
            lbidClasificacion = new Label();
            txtidPelicula = new TextBox();
            txtnombrePelicula = new TextBox();
            txtduracion = new TextBox();
            txtidGenero = new TextBox();
            txtidClasificacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvpelicula).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvpelicula
            // 
            dgvpelicula.AllowUserToAddRows = false;
            dgvpelicula.AllowUserToDeleteRows = false;
            dgvpelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpelicula.Location = new Point(41, 56);
            dgvpelicula.Margin = new Padding(2);
            dgvpelicula.Name = "dgvpelicula";
            dgvpelicula.ReadOnly = true;
            dgvpelicula.RowHeadersWidth = 62;
            dgvpelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpelicula.Size = new Size(920, 326);
            dgvpelicula.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 30);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(64, 25);
            btnNuevo.Text = "Nuevo";
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
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 25);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // lbidGenero
            // 
            lbidGenero.AutoSize = true;
            lbidGenero.Location = new Point(542, 422);
            lbidGenero.Margin = new Padding(4, 0, 4, 0);
            lbidGenero.Name = "lbidGenero";
            lbidGenero.Size = new Size(96, 25);
            lbidGenero.TabIndex = 9;
            lbidGenero.Text = "ID Género:";
            // 
            // lbduracion
            // 
            lbduracion.AutoSize = true;
            lbduracion.Location = new Point(111, 535);
            lbduracion.Margin = new Padding(4, 0, 4, 0);
            lbduracion.Name = "lbduracion";
            lbduracion.Size = new Size(92, 25);
            lbduracion.TabIndex = 8;
            lbduracion.Text = "Duración: ";
            // 
            // lbnombrePelicula
            // 
            lbnombrePelicula.AutoSize = true;
            lbnombrePelicula.Location = new Point(111, 478);
            lbnombrePelicula.Margin = new Padding(4, 0, 4, 0);
            lbnombrePelicula.Name = "lbnombrePelicula";
            lbnombrePelicula.Size = new Size(149, 25);
            lbnombrePelicula.TabIndex = 7;
            lbnombrePelicula.Text = "Nombre Pelicula: ";
            // 
            // lbidPelicula
            // 
            lbidPelicula.AutoSize = true;
            lbidPelicula.Location = new Point(111, 422);
            lbidPelicula.Margin = new Padding(4, 0, 4, 0);
            lbidPelicula.Name = "lbidPelicula";
            lbidPelicula.Size = new Size(101, 25);
            lbidPelicula.TabIndex = 6;
            lbidPelicula.Text = "ID Pelicula: ";
            // 
            // lbidClasificacion
            // 
            lbidClasificacion.AutoSize = true;
            lbidClasificacion.Location = new Point(542, 494);
            lbidClasificacion.Margin = new Padding(4, 0, 4, 0);
            lbidClasificacion.Name = "lbidClasificacion";
            lbidClasificacion.Size = new Size(135, 25);
            lbidClasificacion.TabIndex = 10;
            lbidClasificacion.Text = "ID Clasificación:";
            // 
            // txtidPelicula
            // 
            txtidPelicula.Location = new Point(275, 419);
            txtidPelicula.Margin = new Padding(4);
            txtidPelicula.Name = "txtidPelicula";
            txtidPelicula.Size = new Size(155, 31);
            txtidPelicula.TabIndex = 11;
            // 
            // txtnombrePelicula
            // 
            txtnombrePelicula.Location = new Point(275, 474);
            txtnombrePelicula.Margin = new Padding(4);
            txtnombrePelicula.Name = "txtnombrePelicula";
            txtnombrePelicula.Size = new Size(155, 31);
            txtnombrePelicula.TabIndex = 12;
            // 
            // txtduracion
            // 
            txtduracion.Location = new Point(275, 531);
            txtduracion.Margin = new Padding(4);
            txtduracion.Name = "txtduracion";
            txtduracion.Size = new Size(155, 31);
            txtduracion.TabIndex = 13;
            // 
            // txtidGenero
            // 
            txtidGenero.Location = new Point(696, 419);
            txtidGenero.Margin = new Padding(4);
            txtidGenero.Name = "txtidGenero";
            txtidGenero.Size = new Size(155, 31);
            txtidGenero.TabIndex = 14;
            // 
            // txtidClasificacion
            // 
            txtidClasificacion.Location = new Point(696, 490);
            txtidClasificacion.Margin = new Padding(4);
            txtidClasificacion.Name = "txtidClasificacion";
            txtidClasificacion.Size = new Size(155, 31);
            txtidClasificacion.TabIndex = 15;
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 702);
            Controls.Add(txtidClasificacion);
            Controls.Add(txtidGenero);
            Controls.Add(txtduracion);
            Controls.Add(txtnombrePelicula);
            Controls.Add(txtidPelicula);
            Controls.Add(lbidClasificacion);
            Controls.Add(lbidGenero);
            Controls.Add(lbduracion);
            Controls.Add(lbnombrePelicula);
            Controls.Add(lbidPelicula);
            Controls.Add(dgvpelicula);
            Controls.Add(toolStrip1);
            Margin = new Padding(4);
            Name = "Pelicula";
            Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)dgvpelicula).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvpelicula;
        private ToolStrip toolStrip1;
        private ToolStripLabel btnNuevo;
        private ToolStripLabel btnEditar;
        private ToolStripLabel btnEliminar;
        private ToolStripLabel btnGuardar;
        private ToolStripLabel btnCancelar;
        private ToolStripLabel btnObtener;
        private ToolStripLabel btnSalir;
        private Label lbidGenero;
        private Label lbduracion;
        private Label lbnombrePelicula;
        private Label lbidPelicula;
        private Label lbidClasificacion;
        private TextBox txtidPelicula;
        private TextBox txtnombrePelicula;
        private TextBox txtduracion;
        private TextBox txtidGenero;
        private TextBox txtidClasificacion;
    }
}