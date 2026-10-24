using CineConBD;
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
    public partial class Cliente : Form
    {
        private bool Editar = false;
        public Cliente()
        {
            InitializeComponent();
            ObtenerDatos();
            llenarComboCiudad();
        }

        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT Cl.IDCliente, Cl.Nombre, Cl.Celular, Cl.Correo, Cl.IDCiudad, Ciu.NombreCiudad"
                        + " FROM Cliente AS Cl"
                        + " INNER JOIN Ciudad AS Ciu ON Cl.IDCiudad = Ciu.IDCiudad";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtCliente = new DataTable();
                    adapter.Fill(dtCliente);
                    dgvCliente.DataSource = dtCliente;
                    dgvCliente.Columns["IDCiudad"].Visible = false;
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
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDCiudad, NombreCiudad FROM Ciudad";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datosCiudad = new DataTable();
                    adapter.Fill(datosCiudad);
                    cmbCiudad.DataSource = datosCiudad;
                    cmbCiudad.DisplayMember = "NombreCiudad";
                    cmbCiudad.ValueMember = "IDCiudad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de sucursales: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtCelular.Enabled = true;
            txtCorreo.Enabled = true;
            txtNombreCliente.Enabled = true;
            cmbCiudad.Enabled = true;

            txtIDCliente.Text = "";
            txtNombreCliente.Text = "";
            txtCorreo.Text = "";
            txtCelular.Text = "";
            cmbCiudad.SelectedIndex = -1;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvCliente.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                txtIDCliente.Text = dgvCliente.SelectedRows[0].Cells["IDCliente"].Value.ToString();
                txtNombreCliente.Text = dgvCliente.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtCelular.Text = dgvCliente.SelectedRows[0].Cells["Celular"].Value.ToString();
                txtCorreo.Text = dgvCliente.SelectedRows[0].Cells["Correo"].Value.ToString();
                cmbCiudad.SelectedValue = dgvCliente.SelectedRows[0].Cells["IDCiudad"].Value;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;
            txtNombreCliente.Enabled = true;
            cmbCiudad.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvCliente.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string insertar = "INSERT INTO Cliente (IDCiudad, Nombre,Celular,Correo) " +
                            "VALUES (@IDCiudad, @Nombre, @Celular, @Correo)";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@IDCiudad", cmbCiudad.SelectedValue);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text);
                        comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al ingresar un nuevo cliente");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar los datos: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string insertar = "UPDATE Cliente SET IDCiudad = IDCiudad, Nombre = @Nombre, Celular = @Celular, Correo = @Correo" +
                            " WHERE IDCliente = @IDCliente";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@IDCiudad", cmbCiudad.SelectedValue);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text);
                        comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar el cliente");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
            }
            txtCelular.Enabled = false;
            txtCorreo.Enabled = false;
            txtNombreCliente.Enabled = false;
            cmbCiudad.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvCliente.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar a este cliente?", "Eliminar"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string eliminar = "DELETE FROM Cliente WHERE IDCliente = @IDCliente";
                            SqlCommand comando = new SqlCommand(eliminar, sqlConn);
                            comando.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar el cliente.");
                            }
                        }
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar los datos: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminarlo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvCliente_SelectionChanged(sender, e);

                txtCelular.Enabled = false;
                txtCorreo.Enabled = false;
                txtNombreCliente.Enabled = false;
                cmbCiudad.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvCliente.Enabled = true;
            }
        }
    }
}
