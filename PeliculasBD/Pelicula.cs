using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasBD
{
    public partial class Pelicula : Form
    {
        private bool Editar = false;
        private String conexion = "";
        private SqlConnection sqlConn = null;
        public Pelicula()
        {
            InitializeComponent();
            conexion = "Server=localhost\\SQLExpress;Database=Cine;Trusted_Connection=True;"
                     + "Integrated Security=true; TrustServerCertificate=true";
            sqlConn = new SqlConnection(conexion);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
