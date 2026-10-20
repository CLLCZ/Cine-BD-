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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGenero).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGenero
            // 
            dgvGenero.AllowUserToAddRows = false;
            dgvGenero.AllowUserToDeleteRows = false;
            dgvGenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenero.Location = new Point(44, 52);
            dgvGenero.Margin = new Padding(2);
            dgvGenero.Name = "dgvGenero";
            dgvGenero.ReadOnly = true;
            dgvGenero.RowHeadersWidth = 62;
            dgvGenero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenero.Size = new Size(915, 294);
            dgvGenero.TabIndex = 3;
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
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 25);
            btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
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
            // 
            // lbidGenero
            // 
            lbidGenero.AutoSize = true;
            lbidGenero.Location = new Point(80, 382);
            lbidGenero.Margin = new Padding(4, 0, 4, 0);
            lbidGenero.Name = "lbidGenero";
            lbidGenero.Size = new Size(101, 25);
            lbidGenero.TabIndex = 4;
            lbidGenero.Text = "ID Genero: ";
            // 
            // lbnombreGenero
            // 
            lbnombreGenero.AutoSize = true;
            lbnombreGenero.Location = new Point(88, 458);
            lbnombreGenero.Margin = new Padding(4, 0, 4, 0);
            lbnombreGenero.Name = "lbnombreGenero";
            lbnombreGenero.Size = new Size(178, 25);
            lbnombreGenero.TabIndex = 5;
            lbnombreGenero.Text = "Nombre del Genero: ";
            // 
            // lbdescripcionGenero
            // 
            lbdescripcionGenero.AutoSize = true;
            lbdescripcionGenero.Location = new Point(507, 390);
            lbdescripcionGenero.Margin = new Padding(4, 0, 4, 0);
            lbdescripcionGenero.Name = "lbdescripcionGenero";
            lbdescripcionGenero.Size = new Size(199, 25);
            lbdescripcionGenero.TabIndex = 6;
            lbdescripcionGenero.Text = "Descripción del Genero:";
            // 
            // txtidGenero
            // 
            txtidGenero.Location = new Point(289, 390);
            txtidGenero.Margin = new Padding(4, 4, 4, 4);
            txtidGenero.Name = "txtidGenero";
            txtidGenero.Size = new Size(185, 31);
            txtidGenero.TabIndex = 7;
            // 
            // cbnombreGenero
            // 
            cbnombreGenero.FormattingEnabled = true;
            cbnombreGenero.Items.AddRange(new object[] { "Drama", "Aventura", "Acción", "Comedia", "Terror", "Romance", "Humor negro", "Ciencia Ficción", "Fantasía", "Musical ", "Suspenso" });
            cbnombreGenero.Location = new Point(289, 454);
            cbnombreGenero.Margin = new Padding(4, 4, 4, 4);
            cbnombreGenero.Name = "cbnombreGenero";
            cbnombreGenero.Size = new Size(188, 33);
            cbnombreGenero.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(714, 390);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 31);
            textBox1.TabIndex = 11;
            // 
            // Genero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(textBox1);
            Controls.Add(cbnombreGenero);
            Controls.Add(txtidGenero);
            Controls.Add(lbdescripcionGenero);
            Controls.Add(lbnombreGenero);
            Controls.Add(lbidGenero);
            Controls.Add(dgvGenero);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 4, 4, 4);
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
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}