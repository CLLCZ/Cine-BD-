namespace PeliculasBD
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula peliculaVentana = new Pelicula();
            peliculaVentana.Show();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero generoVentana = new Genero();
            generoVentana.Show();
        }

        private void clasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacionVentana = new Clasificacion();
            clasificacionVentana.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal sucursalVentana = new Sucursal();
            sucursalVentana.Show();
        }
    }
}
