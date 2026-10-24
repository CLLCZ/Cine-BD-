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
    public partial class Ciudad : Form
    {
        private bool Editar = false;
        public Ciudad()
        {
            InitializeComponent();
            ObtenerDatos();
            llenarComboEstado();
        }

        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT C.IDCiudad,C.NombreCiudad, C.SiglasCiudad, C.ClaveCiudad, C.IDEstado, E.NombreEstado"
                        + " FROM Ciudad AS C"
                        + " INNER JOIN Estado AS E ON C.IDEstado = E.IDEstado";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtCiudad = new DataTable();
                    adapter.Fill(dtCiudad);
                    dgvCiudad.DataSource = dtCiudad;
                    dgvCiudad.Columns["IDEstado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private void llenarComboEstado()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDEstado, NombreEstado FROM Estado";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datosEstado = new DataTable();
                    adapter.Fill(datosEstado);
                    cmbEstado.DataSource = datosEstado;
                    cmbEstado.DisplayMember = "NombreEstado";
                    cmbEstado.ValueMember = "IDEstado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de sucursales: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtClave.Enabled = true;
            txtNomCiudad.Enabled = true;
            txtSiglas.Enabled = true;
            cmbEstado.Enabled = true;

            txtIDCiudad.Text = "";
            txtClave.Text = "";
            txtNomCiudad.Text = "";
            txtSiglas.Text = "";
            cmbEstado.SelectedIndex = -1;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvCiudad.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtClave.Enabled = true;
            txtNomCiudad.Enabled = true;
            txtSiglas.Enabled = true;
            cmbEstado.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvCiudad.Enabled = false;
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void dgvCiudad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                txtIDCiudad.Text = dgvCiudad.SelectedRows[0].Cells["IDCiudad"].Value.ToString();
                txtNomCiudad.Text = dgvCiudad.SelectedRows[0].Cells["NombreCiudad"].Value.ToString();
                txtSiglas.Text = dgvCiudad.SelectedRows[0].Cells["SiglasCiudad"].Value.ToString();
                txtClave.Text = dgvCiudad.SelectedRows[0].Cells["ClaveCiudad"].Value.ToString();
                cmbEstado.SelectedValue = dgvCiudad.SelectedRows[0].Cells["IDEstado"].Value;
            }
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
                        string insertar = "INSERT INTO Ciudad (NombreCiudad, SiglasCiudad, ClaveCiudad, IDEstado) " +
                            "VALUES (@NombreCiudad,@SiglasCiudad,@ClaveCiudad,@IDEstado)";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@NombreCiudad", txtNomCiudad.Text);
                        comando.Parameters.AddWithValue("@SiglasCiudad", txtSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveCiudad", txtClave.Text);
                        comando.Parameters.AddWithValue("IDEstado", cmbEstado.SelectedValue);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al registrar la ciudad.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la ciudad: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string insertar = "UPDATE Ciudad SET NombreCiudad = @NombreCiudad, ClaveCiudad = @ClaveCiudad, SiglasCiudad = @SiglasCiudad, " +
                            "IDEstado = @IDEstado WHERE IDCiudad = @IDCiudad";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@NombreCiudad", txtNomCiudad.Text);
                        comando.Parameters.AddWithValue("@SiglasCiudad", txtSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveCiudad", txtClave.Text);
                        comando.Parameters.AddWithValue("IDEstado", cmbEstado.SelectedValue);
                        comando.Parameters.AddWithValue("@IDCiudad", txtIDCiudad.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la ciudad.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la ciudad: " + ex.Message);
                }
            }
            txtClave.Enabled = false;
            txtNomCiudad.Enabled = false;
            txtSiglas.Enabled = false;
            cmbEstado.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvCiudad.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta ciudad?", "Eliminar"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string eliminar = "DELETE FROM Ciudad WHERE IDCiudad = @IDCiudad";
                            SqlCommand comando = new SqlCommand(eliminar, sqlConn);
                            comando.Parameters.AddWithValue("@IDCiudad", txtIDCiudad.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la ciudad.");
                            }
                        }
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar los datos de la ciudad: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ciudad para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;

                dgvCiudad_SelectionChanged(sender, e);  //Volver a cargar los datos en los txt. No creo que sea lo optimo

                txtSiglas.Enabled = false;
                txtNomCiudad.Enabled = false;
                txtClave.Enabled = false;
                cmbEstado.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvCiudad.Enabled = true;
            }
        }
    }
}
