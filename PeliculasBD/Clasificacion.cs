using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PeliculasBD
{
    public partial class Clasificacion : Form
    {
        private bool Editar = false;
        private String conexion = "";
        private SqlConnection sqlConn = null;
        public Clasificacion()
        {
            InitializeComponent();
            conexion = "Server=localhost\\SQLExpress;Database=Cine;Trusted_Connection=True;"
                     + "Integrated Security=true; TrustServerCertificate=true";
            sqlConn = new SqlConnection(conexion);
        }
        /*private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    String consulta = "SELECT";
                }
            }
        }*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtidClasificacion.Text = "";
            txtdescripcion.Text = "";
            txtclave.Text = "";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvClasificacion.Enabled = false;

            txtdescripcion.Enabled = true;
            txtclave.Enabled = true;
        }

        private void dgvClasificacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count > 0)
            {
                DataGridViewRow renglon = dgvClasificacion.SelectedRows[0];
                txtidClasificacion.Text = renglon.Cells["idClasificacion"].Value.ToString();
                txtdescripcion.Text = renglon.Cells["descripcion"].Value.ToString();
                txtclave.Text = renglon.Cells["clave"].Value.ToString();
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {

        }
    }
}
