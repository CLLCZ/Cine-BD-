namespace PeliculasBD
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmenuitemcatalogo = new ToolStripMenuItem();
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            generoToolStripMenuItem = new ToolStripMenuItem();
            clasificacionToolStripMenuItem = new ToolStripMenuItem();
            tipoBoletoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            funciónToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            EstadoToolStripMenuItem = new ToolStripMenuItem();
            ciudadToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmenuitemcatalogo, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmenuitemcatalogo
            // 
            tsmenuitemcatalogo.DropDownItems.AddRange(new ToolStripItem[] { peliculaToolStripMenuItem, generoToolStripMenuItem, clasificacionToolStripMenuItem, tipoBoletoToolStripMenuItem });
            tsmenuitemcatalogo.Name = "tsmenuitemcatalogo";
            tsmenuitemcatalogo.Size = new Size(100, 29);
            tsmenuitemcatalogo.Text = "Catálogo";
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(270, 34);
            peliculaToolStripMenuItem.Text = "Pelicula";
            peliculaToolStripMenuItem.Click += peliculaToolStripMenuItem_Click;
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(270, 34);
            generoToolStripMenuItem.Text = "Género";
            generoToolStripMenuItem.Click += generoToolStripMenuItem_Click;
            // 
            // clasificacionToolStripMenuItem
            // 
            clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            clasificacionToolStripMenuItem.Size = new Size(270, 34);
            clasificacionToolStripMenuItem.Text = "Clasificación";
            clasificacionToolStripMenuItem.Click += clasificacionToolStripMenuItem_Click;
            // 
            // tipoBoletoToolStripMenuItem
            // 
            tipoBoletoToolStripMenuItem.Name = "tipoBoletoToolStripMenuItem";
            tipoBoletoToolStripMenuItem.Size = new Size(270, 34);
            tipoBoletoToolStripMenuItem.Text = "Tipo Boleto";
            tipoBoletoToolStripMenuItem.Click += tipoBoletoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { funciónToolStripMenuItem, salaToolStripMenuItem, sucursalToolStripMenuItem, EstadoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(62, 29);
            toolStripMenuItem1.Text = "Cine";
            // 
            // funciónToolStripMenuItem
            // 
            funciónToolStripMenuItem.Name = "funciónToolStripMenuItem";
            funciónToolStripMenuItem.Size = new Size(270, 34);
            funciónToolStripMenuItem.Text = "Función";
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(270, 34);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(270, 34);
            sucursalToolStripMenuItem.Text = "Sucursal";
            sucursalToolStripMenuItem.Click += sucursalToolStripMenuItem_Click;
            // 
            // EstadoToolStripMenuItem
            // 
            EstadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ciudadToolStripMenuItem });
            EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem";
            EstadoToolStripMenuItem.Size = new Size(270, 34);
            EstadoToolStripMenuItem.Text = "Estado";
            EstadoToolStripMenuItem.Click += EstadoToolStripMenuItem_Click;
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(170, 34);
            ciudadToolStripMenuItem.Text = "Ciudad";
            ciudadToolStripMenuItem.Click += ciudadToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, clienteToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(190, 29);
            toolStripMenuItem2.Text = "Información Clientes";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(167, 34);
            ventaToolStripMenuItem.Text = "Venta";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(167, 34);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmenuitemcatalogo;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem generoToolStripMenuItem;
        private ToolStripMenuItem clasificacionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem funciónToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem sucursalToolStripMenuItem;
        private ToolStripMenuItem EstadoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ciudadToolStripMenuItem;
        private ToolStripMenuItem tipoBoletoToolStripMenuItem;
    }
}
