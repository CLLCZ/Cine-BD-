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
using CineConBD;

namespace PeliculasBD
{
    public partial class Estado : Form
    {
        private bool Editar = false;
        public Estado()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDEstado, NombreEstado, SiglaEstado, ClaveEstado FROM Estado";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtEstado = new DataTable();
                    adapter.Fill(dtEstado);
                    dgvEstado.DataSource = dtEstado;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtClaveEst.Enabled = true;
            txtNombreEst.Enabled = true;
            txtSiglas.Enabled = true;

            txtIDEstado.Text = "";
            txtClaveEst.Text = "";
            txtNombreEst.Text = "";
            txtSiglas.Text = "";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvEstado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtClaveEst.Enabled = true;
            txtNombreEst.Enabled = true;
            txtSiglas.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvEstado.Enabled = false;
        }

        private void dgvEstado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count == 1)
            {
                txtClaveEst.Text = dgvEstado.SelectedRows[0].Cells["ClaveEstado"].Value.ToString();
                txtIDEstado.Text = dgvEstado.SelectedRows[0].Cells["IDEstado"].Value.ToString();
                txtNombreEst.Text = dgvEstado.SelectedRows[0].Cells["NombreEstado"].Value.ToString();
                txtSiglas.Text = dgvEstado.SelectedRows[0].Cells["SiglaEstado"].Value.ToString();
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
                        string consulta = "INSERT INTO Estado (NombreEstado, SiglaEstado, ClaveEstado) " +
                            "VALUES (@NombreEstado, @SiglaEstado, @ClaveEstado)";
                        SqlCommand comando = new SqlCommand(consulta, sqlConn);
                        comando.Parameters.AddWithValue("@NombreEstado", txtNombreEst.Text);
                        comando.Parameters.AddWithValue("@SiglaEstado", txtSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveEstado", txtClaveEst.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Exito al registrar el estado.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el estado: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string consulta = "UPDATE Estado SET NombreEstado = @NombreEstado, SiglaEstado = @SiglaEstado, ClaveEstado = @ClaveEstado" +
                            " WHERE IDEstado = @IDEstado";
                        SqlCommand comando = new SqlCommand(consulta, sqlConn);
                        comando.Parameters.AddWithValue("@NombreEstado", txtNombreEst.Text);
                        comando.Parameters.AddWithValue("@SiglaEstado", txtSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveEstado", txtClaveEst.Text);
                        comando.Parameters.AddWithValue("@IDEstado", txtIDEstado.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Exito al actualizar el estado.");
                        }
                    }
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message);
                }
            }

            txtClaveEst.Enabled = false;
            txtNombreEst.Enabled = false;
            txtSiglas.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvEstado.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este estado?", "Eliminar"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Estado WHERE IDEstado = @IDEstado";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDEstado", txtIDEstado.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Exito al eliminar el estado.");
                            }
                        }
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el estado: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un estado para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvEstado_SelectionChanged(sender, e);

                txtClaveEst.Enabled = false;
                txtNombreEst.Enabled = false;
                txtSiglas.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvEstado.Enabled = true;
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
    }
}
