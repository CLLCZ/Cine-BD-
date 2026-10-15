namespace PeliculasBD
{
    partial class Genero
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
            dgvGenero = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripLabel();
            btnEditar = new ToolStripLabel();
            btnEliminar = new ToolStripLabel();
            btnGuardar = new ToolStripLabel();
            btnCancelar = new ToolStripLabel();
            btnObtener = new ToolStripLabel();
            btnSalir = new ToolStripLabel();
            lbidGenero = new Label();
            lbnombreGenero = new Label();
            lbdescripcionGenero = new Label();
            txtidGenero = new TextBox();
            cbnombreGenero = new ComboBox();
            cbdescripciongenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGenero).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGenero
            // 
            dgvGenero.AllowUserToAddRows = false;
            dgvGenero.AllowUserToDeleteRows = false;
            dgvGenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenero.Location = new Point(35, 42);
            dgvGenero.Margin = new Padding(2);
            dgvGenero.Name = "dgvGenero";
            dgvGenero.ReadOnly = true;
            dgvGenero.RowHeadersWidth = 62;
            dgvGenero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenero.Size = new Size(732, 235);
            dgvGenero.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnGuardar, btnCancelar, btnObtener, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
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
            // 
            // lbidGenero
            // 
            lbidGenero.AutoSize = true;
            lbidGenero.Location = new Point(135, 319);
            lbidGenero.Name = "lbidGenero";
            lbidGenero.Size = new Size(83, 20);
            lbidGenero.TabIndex = 4;
            lbidGenero.Text = "ID Genero: ";
            // 
            // lbnombreGenero
            // 
            lbnombreGenero.AutoSize = true;
            lbnombreGenero.Location = new Point(70, 366);
            lbnombreGenero.Name = "lbnombreGenero";
            lbnombreGenero.Size = new Size(148, 20);
            lbnombreGenero.TabIndex = 5;
            lbnombreGenero.Text = "Nombre del Genero: ";
            // 
            // lbdescripcionGenero
            // 
            lbdescripcionGenero.AutoSize = true;
            lbdescripcionGenero.Location = new Point(444, 319);
            lbdescripcionGenero.Name = "lbdescripcionGenero";
            lbdescripcionGenero.Size = new Size(167, 20);
            lbdescripcionGenero.TabIndex = 6;
            lbdescripcionGenero.Text = "Descripción del Genero:";
            // 
            // txtidGenero
            // 
            txtidGenero.Location = new Point(231, 312);
            txtidGenero.Name = "txtidGenero";
            txtidGenero.Size = new Size(149, 27);
            txtidGenero.TabIndex = 7;
            // 
            // cbnombreGenero
            // 
            cbnombreGenero.FormattingEnabled = true;
            cbnombreGenero.Items.AddRange(new object[] { "Drama", "Aventura", "Acción", "Comedia", "Terror", "Romance", "Humor negro", "Ciencia Ficción", "Fantasía", "Musical ", "Suspenso" });
            cbnombreGenero.Location = new Point(231, 363);
            cbnombreGenero.Name = "cbnombreGenero";
            cbnombreGenero.Size = new Size(151, 28);
            cbnombreGenero.TabIndex = 10;
            // 
            // cbdescripciongenero
            // 
            cbdescripciongenero.FormattingEnabled = true;
            cbdescripciongenero.Location = new Point(489, 358);
            cbdescripciongenero.Name = "cbdescripciongenero";
            cbdescripciongenero.Size = new Size(227, 28);
            cbdescripciongenero.TabIndex = 11;
            // 
            // Genero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbdescripciongenero);
            Controls.Add(cbnombreGenero);
            Controls.Add(txtidGenero);
            Controls.Add(lbdescripcionGenero);
            Controls.Add(lbnombreGenero);
            Controls.Add(lbidGenero);
            Controls.Add(dgvGenero);
            Controls.Add(toolStrip1);
            Name = "Genero";
            Text = "Genero";
            ((System.ComponentModel.ISupportInitialize)dgvGenero).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGenero;
        private ToolStrip toolStrip1;
        private ToolStripLabel btnNuevo;
        private ToolStripLabel btnEditar;
        private ToolStripLabel btnEliminar;
        private ToolStripLabel btnGuardar;
        private ToolStripLabel btnCancelar;
        private ToolStripLabel btnObtener;
        private ToolStripLabel btnSalir;
        private Label lbidGenero;
        private Label lbnombreGenero;
        private Label lbdescripcionGenero;
        private TextBox txtidGenero;
        private ComboBox cbnombreGenero;
        private ComboBox cbdescripciongenero;
    }
}