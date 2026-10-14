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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvpelicula).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvpelicula
            // 
            dgvpelicula.AllowUserToAddRows = false;
            dgvpelicula.AllowUserToDeleteRows = false;
            dgvpelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpelicula.Location = new Point(33, 45);
            dgvpelicula.Margin = new Padding(2);
            dgvpelicula.Name = "dgvpelicula";
            dgvpelicula.ReadOnly = true;
            dgvpelicula.RowHeadersWidth = 62;
            dgvpelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpelicula.Size = new Size(736, 261);
            dgvpelicula.TabIndex = 3;
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
            lbidGenero.Location = new Point(434, 338);
            lbidGenero.Name = "lbidGenero";
            lbidGenero.Size = new Size(79, 20);
            lbidGenero.TabIndex = 9;
            lbidGenero.Text = "ID Género:";
            // 
            // lbduracion
            // 
            lbduracion.AutoSize = true;
            lbduracion.Location = new Point(89, 428);
            lbduracion.Name = "lbduracion";
            lbduracion.Size = new Size(76, 20);
            lbduracion.TabIndex = 8;
            lbduracion.Text = "Duración: ";
            // 
            // lbnombrePelicula
            // 
            lbnombrePelicula.AutoSize = true;
            lbnombrePelicula.Location = new Point(89, 382);
            lbnombrePelicula.Name = "lbnombrePelicula";
            lbnombrePelicula.Size = new Size(125, 20);
            lbnombrePelicula.TabIndex = 7;
            lbnombrePelicula.Text = "Nombre Pelicula: ";
            // 
            // lbidPelicula
            // 
            lbidPelicula.AutoSize = true;
            lbidPelicula.Location = new Point(89, 338);
            lbidPelicula.Name = "lbidPelicula";
            lbidPelicula.Size = new Size(85, 20);
            lbidPelicula.TabIndex = 6;
            lbidPelicula.Text = "ID Pelicula: ";
            // 
            // lbidClasificacion
            // 
            lbidClasificacion.AutoSize = true;
            lbidClasificacion.Location = new Point(434, 395);
            lbidClasificacion.Name = "lbidClasificacion";
            lbidClasificacion.Size = new Size(114, 20);
            lbidClasificacion.TabIndex = 10;
            lbidClasificacion.Text = "ID Clasificación:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 335);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 379);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 425);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(557, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(557, 392);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbidClasificacion);
            Controls.Add(lbidGenero);
            Controls.Add(lbduracion);
            Controls.Add(lbnombrePelicula);
            Controls.Add(lbidPelicula);
            Controls.Add(dgvpelicula);
            Controls.Add(toolStrip1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}