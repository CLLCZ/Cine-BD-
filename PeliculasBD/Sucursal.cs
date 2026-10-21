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
    public partial class Sucursal : Form
    {
        private bool Editar = false;
        private String conexion = "";
        private SqlConnection sqlConn = null;
        public Sucursal()
        {
            InitializeComponent();
            conexion = "Server=localhost\\SQLExpress;Database=Cine;Trusted_Connection=True;"
                     + "Integrated Security=true; TrustServerCertificate=true";
            sqlConn = new SqlConnection(conexion);
            ObtenerDatos();
            llenarComboCiudad();
        }

        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    string consulta = "SELECT S.IDSucursal, S.Nombre,S.Direccion,S.IDCiudad,C.NombreCiudad "
                        + "FROM Cine.dbo.Sucursal AS S "
                        + "INNER JOIN Cine.dbo.Ciudad C ON C.IDCiudad = S.IDCiudad";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtSucursal = new DataTable();
                    adapter.Fill(dtSucursal);
                    dgvSucursal.DataSource = dtSucursal;
                    dgvSucursal.Columns["IDCiudad"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }


        private void llenarComboCiudad()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDCiudad, NombreCiudad FROM Cine.dbo.Ciudad";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datosCiudad = new DataTable();
                    adapter.Fill(datosCiudad);
                    cmbCiudad.DataSource = datosCiudad;
                    cmbCiudad.ValueMember = "IDCiudad";
                    cmbCiudad.DisplayMember = "NombreCiudad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de ciudad: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtNombreSucursal.Enabled = true;
            txtDireccion.Enabled = true;
            cmbCiudad.Enabled = true;

            txtIdSucursal.Text = "";
            txtDireccion.Text = "";
            txtNombreSucursal.Text = "";
            cmbCiudad.SelectedIndex = -1;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvSucursal.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtNombreSucursal.Enabled = true;
            txtDireccion.Enabled = true;
            cmbCiudad.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvSucursal.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta sucursal?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = new SqlConnection(conexion))
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Sucursal WHERE IDSucursal = @IDSucursal";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDSucursal", txtIdSucursal.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la Sucursal.");
                            }
                        }
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la sucursal: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal para eliminar.");
            }
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
                        string insertar = "INSERT INTO Cine.dbo.Sucursal (Nombre, Direccion, IDCiudad) VALUES (@Nombre, @Direccion, @IDCiudad)";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreSucursal.Text);
                        comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        comando.Parameters.AddWithValue("@IDCiudad", cmbCiudad.SelectedValue);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al insertar la Sucursal.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la Sucursal: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(conexion))
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Sucursal SET Nombre = @Nombre, Direccion = @Direccion, IDCiudad = @IDCiudad WHERE IDSucursal = @IDSucursal";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreSucursal.Text);
                        comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        comando.Parameters.AddWithValue("@IDCiudad", cmbCiudad.SelectedValue);
                        comando.Parameters.AddWithValue("@IDSucursal", txtIdSucursal.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la Sucursal.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la Sucursal: " + ex.Message);
                }
            }

            txtDireccion.Enabled = false;
            cmbCiudad.Enabled = false;
            txtNombreSucursal.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvSucursal.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                txtNombreSucursal.Text = "";
                txtIdSucursal.Text = "";
                txtDireccion.Text = "";
                cmbCiudad.SelectedIndex = -1;

                txtNombreSucursal.Enabled = false;
                txtDireccion.Enabled = false;
                cmbCiudad.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvSucursal.Enabled = true;
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count == 1)
            {
                txtIdSucursal.Text = dgvSucursal.SelectedRows[0].Cells["IDSucursal"].Value.ToString();
                txtNombreSucursal.Text = dgvSucursal.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvSucursal.SelectedRows[0].Cells["Direccion"].Value.ToString();
                cmbCiudad.SelectedValue = dgvSucursal.SelectedRows[0].Cells["IDCiudad"].Value;
            }
        }
    }
}
