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
        private SqlConnection sqlConnection = null;
        public Clasificacion()
        {
            InitializeComponent();
            conexion = "Server=localhost\\SQLExpress;Database=Cine;Trusted_Connection=True;"
                     + "Integrated Security=true; TrustServerCertificate=true";
            sqlConnection = new SqlConnection(conexion);
            ObtenerDatosBD();
        }

        private void ObtenerDatosBD()
        {
            try
            {
               if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }  
               if(sqlConnection.State != ConnectionState.Open)
                {
                    String consulta = "";
                    SqlCommand comando = new SqlCommand(consulta, sqlConnection);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }
       
        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatosBD();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtclave.Enabled = true;
            txtdescripcion.Enabled = true;
            txtidClasificacion.Enabled = true;
            cbclave.Enabled = true;
            cbdescripcion.Enabled = true;

            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = true;
            btnObtener.Enabled = true;
            btnSalir.Enabled = true;

            dgvClasificacion.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                try
                {
                    using (SqlConnection s = new SqlConnection(conexion))
                    {

                    }
                }
            }
        }
    }
}
