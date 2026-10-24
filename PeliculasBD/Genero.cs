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
using CineConBD;

namespace PeliculasBD
{
    public partial class Genero : Form
    {
        private bool Editar = false;
        public Genero()
        {
            InitializeComponent();
            ObtenerDatosBD();
        }

        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    String consulta = "SELECT IDGenero, NombreGenero, DescripcionGenero FROM Cine.dbo.Genero;";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtGenero = new DataTable();
                    adapter.Fill(dtGenero);
                    dgvGenero.DataSource = dtGenero;
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

            txtdescripcionGenero.Enabled = true;
            txtnombreGenero.Enabled = true;

            txtdescripcionGenero.Text = " ";
            txtidGenero.Text = " ";
            txtnombreGenero.Text = " ";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvGenero.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtdescripcionGenero.Enabled = true;
            txtnombreGenero.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvGenero.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este genero?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Genero WHERE IDGenero = @IDGenero;";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDGenero", txtidGenero.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar el genero.");
                            }
                        }
                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el genero: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un genero a eliminar.");
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
                        string insertar = "INSERT INTO Cine.dbo.Genero (NombreGenero, DescripcionGenero) VALUES (@NombreGenero, @DescripcionGenero);";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@NombreGenero", txtnombreGenero.Text);
                        comando.Parameters.AddWithValue("@DescripcionGenero", txtdescripcionGenero.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al insertar el género.");
                        }
                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exito al insertar el género.");
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Genero SET NombreGenero = @NombreGenero, DescripcionGenero = @DescripcionGenero WHERE IDGenero = @IDGenero;";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@NombreGenero", txtnombreGenero.Text);
                        comando.Parameters.AddWithValue("@DescripcionGenero", txtdescripcionGenero.Text);
                        comando.Parameters.AddWithValue("@IDGenero", txtidGenero.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar el género.");
                        }

                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el género: " + ex.Message);
                }
            }
            txtdescripcionGenero.Enabled = false;
            txtnombreGenero.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvGenero.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la accion actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvGenero_SelectionChanged(sender, e);

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvGenero.Enabled = true;
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

        private void dgvGenero_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvGenero.SelectedRows.Count > 0)
            {
                txtidGenero.Text = dgvGenero.SelectedRows[0].Cells["IDGenero"].Value.ToString();
                txtdescripcionGenero.Text = dgvGenero.SelectedRows[0].Cells["DescripcionGenero"].Value.ToString();
                txtnombreGenero.Text = dgvGenero.SelectedRows[0].Cells["NombreGenero"].Value.ToString();
            }
        }
    }
}
