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
            tipoDeBoletoToolStripMenuItem = new ToolStripMenuItem();
            ciudadYEstadoToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmenuitemcatalogo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmenuitemcatalogo
            // 
            tsmenuitemcatalogo.DropDownItems.AddRange(new ToolStripItem[] { peliculaToolStripMenuItem, generoToolStripMenuItem, clasificacionToolStripMenuItem, tipoDeBoletoToolStripMenuItem, ciudadYEstadoToolStripMenuItem, sucursalToolStripMenuItem });
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
            // tipoDeBoletoToolStripMenuItem
            // 
            tipoDeBoletoToolStripMenuItem.Name = "tipoDeBoletoToolStripMenuItem";
            tipoDeBoletoToolStripMenuItem.Size = new Size(270, 34);
            tipoDeBoletoToolStripMenuItem.Text = "Tipo de Boleto";
            tipoDeBoletoToolStripMenuItem.Click += tipoDeBoletoToolStripMenuItem_Click;
            // 
            // ciudadYEstadoToolStripMenuItem
            // 
            ciudadYEstadoToolStripMenuItem.Name = "ciudadYEstadoToolStripMenuItem";
            ciudadYEstadoToolStripMenuItem.Size = new Size(270, 34);
            ciudadYEstadoToolStripMenuItem.Text = "Ciudad y Estado";
            ciudadYEstadoToolStripMenuItem.Click += ciudadYEstadoToolStripMenuItem_Click;
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(270, 34);
            sucursalToolStripMenuItem.Text = "Sucursal";
            sucursalToolStripMenuItem.Click += sucursalToolStripMenuItem_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 471);
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
        private ToolStripMenuItem tipoDeBoletoToolStripMenuItem;
        private ToolStripMenuItem ciudadYEstadoToolStripMenuItem;
        private ToolStripMenuItem sucursalToolStripMenuItem;
    }
}
