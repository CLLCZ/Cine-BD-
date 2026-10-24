using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineConBD;
using Microsoft.Data.SqlClient;

namespace PeliculasBD
{
    public partial class Sala : Form
    {
        private bool Editar = false;
        public Sala()
        {
            InitializeComponent();
            ObtenerDatos();
            llenarComboSucursal();
        }


        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT Sa.IDSala, Sa.NumeroSala, Sa.TipoSala, Sa.CantidadAsientos, Suc.IDSucursal,Suc.Nombre"
                        + " FROM Sala AS Sa"
                        + " INNER JOIN Sucursal AS Suc ON Sa.IDSucursal = Suc.IDSucursal";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtSala = new DataTable();
                    adapter.Fill(dtSala);
                    dgvSala.DataSource = dtSala;
                    dgvSala.Columns["IDSucursal"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private void llenarComboSucursal()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDSucursal, Nombre FROM Sucursal";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datosSucursal = new DataTable();
                    adapter.Fill(datosSucursal);
                    cmbSucursal.DataSource = datosSucursal;
                    cmbSucursal.DisplayMember = "Nombre";
                    cmbSucursal.ValueMember = "IDSucursal";
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

            txtAsientos.Enabled = true;
            txtNumSala.Enabled = true;
            txtTipoSala.Enabled = true;
            cmbSucursal.Enabled = true;

            txtIDSala.Text = "";
            txtAsientos.Text = "";
            txtNumSala.Text = "";
            txtTipoSala.Text = "";
            cmbSucursal.SelectedIndex = -1;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvSala.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSala_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                txtIDSala.Text = dgvSala.SelectedRows[0].Cells["IDSala"].Value.ToString();
                txtNumSala.Text = dgvSala.SelectedRows[0].Cells["NumeroSala"].Value.ToString();
                txtTipoSala.Text = dgvSala.SelectedRows[0].Cells["TipoSala"].Value.ToString();
                txtAsientos.Text = dgvSala.SelectedRows[0].Cells["CantidadAsientos"].Value.ToString();
                cmbSucursal.SelectedValue = dgvSala.SelectedRows[0].Cells["IDSucursal"].Value;
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtAsientos.Enabled = true;
            txtNumSala.Enabled = true;
            txtTipoSala.Enabled = true;
            cmbSucursal.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvSala.Enabled = false;
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
                        string insertar = "INSERT INTO Sala (NumeroSala, TipoSala, CantidadAsientos, IDSucursal)"
                            + " VALUES (@NumeroSala, @TipoSala, @CantidadAsientos, @IDSucursal)";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@NumeroSala", txtNumSala.Text);
                        comando.Parameters.AddWithValue("@TipoSala", txtTipoSala.Text);
                        comando.Parameters.AddWithValue("@CantidadAsientos", txtAsientos.Text);
                        comando.Parameters.AddWithValue("@IDSucursal", cmbSucursal.SelectedValue);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al ingresar una nueva sala.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Sala SET NumeroSala = @NumeroSala, TipoSala = @TipoSala, "
                            + "CantidadAsientos = @CantidadAsientos, IDSucursal = @IDSucursal"
                            + " WHERE IDSala = @IDSala";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@NumeroSala", txtNumSala.Text);
                        comando.Parameters.AddWithValue("@TipoSala", txtTipoSala.Text);
                        comando.Parameters.AddWithValue("@CantidadAsientos", txtAsientos.Text);
                        comando.Parameters.AddWithValue("@IDSucursal", cmbSucursal.SelectedValue);
                        comando.Parameters.AddWithValue("@IDSala", txtIDSala.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la sala.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
            }

            txtAsientos.Enabled = false;
            txtNumSala.Enabled = false;
            txtTipoSala.Enabled = false;
            cmbSucursal.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvSala.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este tipo de sala?", "Eliminar"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string eliminar = "DELETE FROM Sala WHERE IDSala = @IDSala";
                            SqlCommand comando = new SqlCommand(eliminar, sqlConn);
                            comando.Parameters.AddWithValue("@IDSala", txtIDSala.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la sala.");
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
                MessageBox.Show("Seleccione una sala para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvSala_SelectionChanged(sender, e);

                txtAsientos.Enabled = false;
                txtNumSala.Enabled = false;
                txtTipoSala.Enabled = false;
                cmbSucursal.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvSala.Enabled = true;
            }
        }
    }
}
