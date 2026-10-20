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
            toolStripMenuItem1 = new ToolStripMenuItem();
            funciónToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            ciudadYEstadoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            tipoDeBoletoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmenuitemcatalogo, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(640, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmenuitemcatalogo
            // 
            tsmenuitemcatalogo.DropDownItems.AddRange(new ToolStripItem[] { peliculaToolStripMenuItem, generoToolStripMenuItem, clasificacionToolStripMenuItem });
            tsmenuitemcatalogo.Name = "tsmenuitemcatalogo";
            tsmenuitemcatalogo.Size = new Size(84, 24);
            tsmenuitemcatalogo.Text = "Catálogo";
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(224, 26);
            peliculaToolStripMenuItem.Text = "Pelicula";
            peliculaToolStripMenuItem.Click += peliculaToolStripMenuItem_Click;
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(224, 26);
            generoToolStripMenuItem.Text = "Género";
            generoToolStripMenuItem.Click += generoToolStripMenuItem_Click;
            // 
            // clasificacionToolStripMenuItem
            // 
            clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            clasificacionToolStripMenuItem.Size = new Size(224, 26);
            clasificacionToolStripMenuItem.Text = "Clasificación";
            clasificacionToolStripMenuItem.Click += clasificacionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { funciónToolStripMenuItem, salaToolStripMenuItem, sucursalToolStripMenuItem, ciudadYEstadoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(29, 24);
            toolStripMenuItem1.Text = "..";
            // 
            // funciónToolStripMenuItem
            // 
            funciónToolStripMenuItem.Name = "funciónToolStripMenuItem";
            funciónToolStripMenuItem.Size = new Size(224, 26);
            funciónToolStripMenuItem.Text = "Función";
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(224, 26);
            salaToolStripMenuItem.Text = "Sala";
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(224, 26);
            sucursalToolStripMenuItem.Text = "Sucursal";
            // 
            // ciudadYEstadoToolStripMenuItem
            // 
            ciudadYEstadoToolStripMenuItem.Name = "ciudadYEstadoToolStripMenuItem";
            ciudadYEstadoToolStripMenuItem.Size = new Size(224, 26);
            ciudadYEstadoToolStripMenuItem.Text = "Ciudad y Estado";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, clienteToolStripMenuItem, tipoDeBoletoToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(38, 24);
            toolStripMenuItem2.Text = ".....";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(224, 26);
            ventaToolStripMenuItem.Text = "Venta";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // tipoDeBoletoToolStripMenuItem
            // 
            tipoDeBoletoToolStripMenuItem.Name = "tipoDeBoletoToolStripMenuItem";
            tipoDeBoletoToolStripMenuItem.Size = new Size(224, 26);
            tipoDeBoletoToolStripMenuItem.Text = "Tipo de Boleto";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
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
        private ToolStripMenuItem ciudadYEstadoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem tipoDeBoletoToolStripMenuItem;
    }
}
