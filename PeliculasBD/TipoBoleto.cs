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
    public partial class TipoBoleto : Form
    {
        private bool Editar = false;
        private String conexion = "";
        private SqlConnection sqlConn = null;
        public TipoBoleto()
        {
            InitializeComponent();
            conexion = "Server=localhost\\SQLExpress;Database=Cine;Trusted_Connection=True;"
                     + "Integrated Security=true; TrustServerCertificate=true";
            sqlConn = new SqlConnection(conexion);
            ObtenerDatos();
        }
        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    String consulta = "SELECT IDTipoBoleto,Clave,Descripcion,Precio FROM dbo.TipoBoleto";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtTipoBoleto = new DataTable();
                    adapter.Fill(dtTipoBoleto);
                    dgvTipoBoleto.DataSource = dtTipoBoleto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtidTipoBoleto.Text = "";
            txtDescripcion.Text = "";
            txtClave.Text = "";
            txtPrecio.Text = "";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvTipoBoleto.Enabled = false;

            txtDescripcion.Enabled = true;
            txtClave.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void dgvTipoBoleto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipoBoleto.SelectedRows.Count == 1)
            {
                txtidTipoBoleto.Text = dgvTipoBoleto.SelectedRows[0].Cells["IDTipoBoleto"].Value.ToString();
                txtClave.Text = dgvTipoBoleto.SelectedRows[0].Cells["Clave"].Value.ToString();
                txtDescripcion.Text = dgvTipoBoleto.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvTipoBoleto.SelectedRows[0].Cells["Precio"].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvTipoBoleto.Enabled = false;

            txtDescripcion.Enabled = true;
            txtClave.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(conexion))
                    {
                        sqlConn.Open();
                        string insertar = "INSERT INTO dbo.TipoBoleto     (Clave,Descripcion,Precio) VALUES (@Clave,@Descripcion,@Precio)";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                        comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al guardar el registro.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el registro: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(conexion))
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE dbo.TipoBoleto SET Clave = @Clave, Descripcion = @Descripcion, Precio = @Precio WHERE IDTipoBoleto = @IdTipoBoleto";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                        comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        comando.Parameters.AddWithValue("@IdTipoBoleto", Convert.ToInt32(txtidTipoBoleto.Text));

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar el registro.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
            }
            txtDescripcion.Enabled = false;
            txtClave.Enabled = false;
            txtPrecio.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvTipoBoleto.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "¿Cancelar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                txtidTipoBoleto.Text = "";
                txtDescripcion.Text = "";
                txtClave.Text = "";
                txtPrecio.Text = "";

                txtDescripcion.Enabled = false;
                txtClave.Enabled = false;
                txtPrecio.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvTipoBoleto.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoBoleto.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este tipo de boleto?", "¿Eliminar?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = new SqlConnection(conexion))
                        {
                            sqlConn.Open();
                            string eliminar = "DELETE FROM dbo.TipoBoleto WHERE IDTipoBoleto = @IdTipoBoleto";
                            SqlCommand comando = new SqlCommand(eliminar, sqlConn);
                            comando.Parameters.AddWithValue("@IdTipoBoleto", Convert.ToInt32(txtidTipoBoleto.Text));
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar el registro.");
                            }
                        }
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto para eliminar.");
            }
        }
    }
}
