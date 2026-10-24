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

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudad ciudadVentana = new Ciudad();
            ciudadVentana.Show();
        }

        private void EstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado estadoVentana = new Estado();
            estadoVentana.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente clienteVentana = new Cliente();
            clienteVentana.Show();
        }

        private void tipoBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoBoleto tipoBoletoVentana = new TipoBoleto();
            tipoBoletoVentana.Show();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sala salaVentana = new Sala();
            salaVentana.Show();
        }
    }
}
