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
            Pelicula peliculaForm = new Pelicula();
            peliculaForm.Show();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero generoForm = new Genero();
            generoForm.Show();
        }

        private void clasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacionForm = new Clasificacion();
            clasificacionForm.Show();
        }

        private void tipoDeBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoBoleto tipoBoletoForm = new TipoBoleto();
            tipoBoletoForm.Show();
        }

        private void ciudadYEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CiudadEstado ciudadEstadoForm = new CiudadEstado();
            ciudadEstadoForm.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal sucursalForm = new Sucursal();
            sucursalForm.Show();
        }
    }
}
