namespace PeliculasBD
{
    partial class Funcion
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
            dgvFuncion = new DataGridView();
            lbidFuncion = new Label();
            lbidPelicula = new Label();
            lbidSala = new Label();
            lbFecha = new Label();
            lbHora = new Label();
            txtidFuncion = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            checkedListBoxHora = new CheckedListBox();
            cbPelicula = new ComboBox();
            cbSala = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).BeginInit();
            SuspendLayout();
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
            // dgvFuncion
            // 
            dgvFuncion.AllowUserToAddRows = false;
            dgvFuncion.AllowUserToDeleteRows = false;
            dgvFuncion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFuncion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncion.Location = new Point(15, 48);
            dgvFuncion.Margin = new Padding(4);
            dgvFuncion.Name = "dgvFuncion";
            dgvFuncion.ReadOnly = true;
            dgvFuncion.RowHeadersWidth = 51;
            dgvFuncion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncion.Size = new Size(960, 235);
            dgvFuncion.TabIndex = 4;
            dgvFuncion.SelectionChanged += dgvFuncion_SelectionChanged;
            // 
            // lbidFuncion
            // 
            lbidFuncion.AutoSize = true;
            lbidFuncion.Location = new Point(80, 326);
            lbidFuncion.Margin = new Padding(4, 0, 4, 0);
            lbidFuncion.Name = "lbidFuncion";
            lbidFuncion.Size = new Size(106, 25);
            lbidFuncion.TabIndex = 5;
            lbidFuncion.Text = "ID Funcion: ";
            // 
            // lbidPelicula
            // 
            lbidPelicula.AutoSize = true;
            lbidPelicula.Location = new Point(79, 406);
            lbidPelicula.Margin = new Padding(4, 0, 4, 0);
            lbidPelicula.Name = "lbidPelicula";
            lbidPelicula.Size = new Size(78, 25);
            lbidPelicula.TabIndex = 6;
            lbidPelicula.Text = "Pelicula: ";
            // 
            // lbidSala
            // 
            lbidSala.AutoSize = true;
            lbidSala.Location = new Point(80, 481);
            lbidSala.Margin = new Padding(4, 0, 4, 0);
            lbidSala.Name = "lbidSala";
            lbidSala.Size = new Size(48, 25);
            lbidSala.TabIndex = 7;
            lbidSala.Text = "Sala:";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(401, 326);
            lbFecha.Margin = new Padding(4, 0, 4, 0);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(66, 25);
            lbFecha.TabIndex = 8;
            lbFecha.Text = "Fecha: ";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Location = new Point(402, 406);
            lbHora.Margin = new Padding(4, 0, 4, 0);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(65, 25);
            lbHora.TabIndex = 9;
            lbHora.Text = "Hora:  ";
            // 
            // txtidFuncion
            // 
            txtidFuncion.Location = new Point(214, 320);
            txtidFuncion.Margin = new Padding(4);
            txtidFuncion.Name = "txtidFuncion";
            txtidFuncion.ReadOnly = true;
            txtidFuncion.Size = new Size(155, 31);
            txtidFuncion.TabIndex = 10;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFecha.Enabled = false;
            dateTimePickerFecha.Location = new Point(476, 326);
            dateTimePickerFecha.Margin = new Padding(4);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(312, 31);
            dateTimePickerFecha.TabIndex = 15;
            // 
            // checkedListBoxHora
            // 
            checkedListBoxHora.Enabled = false;
            checkedListBoxHora.FormattingEnabled = true;
            checkedListBoxHora.Items.AddRange(new object[] { "800", "815", "830", "845", "900", "915", "930", "945", "1000", "1015", "1030", "1045", "1100", "1115", "1130", "1145", "1200", "1215", "1230", "1245", "1300", "1315", "1330", "1345", "1400", "1415", "1430", "1445", "1500", "1515", "1530", "1545", "1600", "1615", "1630", "1645", "1700", "1715", "1730", "1745", "1800", "1815", "1830", "1845", "1900", "1915", "1930", "1945", "2000", "2015", "2030", "2045" });
            checkedListBoxHora.Location = new Point(476, 406);
            checkedListBoxHora.Margin = new Padding(4);
            checkedListBoxHora.Name = "checkedListBoxHora";
            checkedListBoxHora.Size = new Size(186, 88);
            checkedListBoxHora.TabIndex = 17;
            // 
            // cbPelicula
            // 
            cbPelicula.Enabled = false;
            cbPelicula.FormattingEnabled = true;
            cbPelicula.Location = new Point(200, 406);
            cbPelicula.Margin = new Padding(4);
            cbPelicula.Name = "cbPelicula";
            cbPelicula.Size = new Size(188, 33);
            cbPelicula.TabIndex = 18;
            // 
            // cbSala
            // 
            cbSala.Enabled = false;
            cbSala.FormattingEnabled = true;
            cbSala.Location = new Point(200, 478);
            cbSala.Margin = new Padding(4);
            cbSala.Name = "cbSala";
            cbSala.Size = new Size(188, 33);
            cbSala.TabIndex = 19;
            // 
            // Funcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(cbSala);
            Controls.Add(cbPelicula);
            Controls.Add(checkedListBoxHora);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(txtidFuncion);
            Controls.Add(lbHora);
            Controls.Add(lbFecha);
            Controls.Add(lbidSala);
            Controls.Add(lbidPelicula);
            Controls.Add(lbidFuncion);
            Controls.Add(dgvFuncion);
            Controls.Add(toolStrip1);
            Margin = new Padding(4);
            Name = "Funcion";
            Text = "Funcion";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).EndInit();
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
        private DataGridView dgvFuncion;
        private Label lbidFuncion;
        private Label lbidPelicula;
        private Label lbidSala;
        private Label lbFecha;
        private Label lbHora;
        private TextBox txtidFuncion;
        private DateTimePicker dateTimePickerFecha;
        private CheckedListBox checkedListBoxHora;
        private ComboBox cbPelicula;
        private ComboBox cbSala;
    }
}