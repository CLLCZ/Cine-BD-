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
    public partial class Clasificacion : Form
    {
        private bool Editar = false;
        public Clasificacion()
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
                    String consulta = "SELECT IDClasificacion, Clave, Descripcion, FecharHoraCreacion FROM Cine.dbo.Clasificacion;";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtClasificacion = new DataTable();
                    adapter.Fill(dtClasificacion);
                    dgvClasificacion.DataSource = dtClasificacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
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
            txtClaveClasif.Enabled = true;
            txtDescrip.Enabled = true;
            dateTimePickerFechaCreacion.Enabled = true;

            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnObtener.Enabled = false;
            btnSalir.Enabled = false;

            dgvClasificacion.Enabled = false;

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
                        string insertar = "INSERT INTO Cine.dbo.Clasificacion (Clave, Descripcion, FecharHoraCreacion) VALUES (@Clave, @Descripcion, @FecharHoraCreacion);";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@Clave", txtClaveClasif.Text);
                        comando.Parameters.AddWithValue("@Descripcion", txtDescrip.Text);
                        comando.Parameters.AddWithValue("@FecharHoraCreacion", dateTimePickerFechaCreacion.Value);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al insertar la clasificación.");
                        }
                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exito al insertar la clasificación.");
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Clasificacion SET Clave = @Clave, Descripcion = @Descripcion, FecharHoraCreacion = @FecharHoraCreacion WHERE IDClasificacion = @IDClasificacion;";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@Clave", txtClaveClasif.Text);
                        comando.Parameters.AddWithValue("@Descripcion", txtDescrip.Text);
                        comando.Parameters.AddWithValue("@FecharHoraCreacion", dateTimePickerFechaCreacion.Value);
                        comando.Parameters.AddWithValue("@IDClasificacion", txtidClasificacion.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la clasificación.");
                        }

                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la clasificación: " + ex.Message);
                }
            }
            txtClaveClasif.Enabled = false;
            txtidClasificacion.Enabled = false;
            txtDescrip.Enabled = false;
            dateTimePickerFechaCreacion.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvClasificacion.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtDescrip.Enabled = true;
            txtClaveClasif.Enabled = true;
            dateTimePickerFechaCreacion.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvClasificacion.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta clasificacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Clasificacion WHERE IDClasificacion = @IDClasificacion;";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDClasificacion", txtidClasificacion.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la clasificacion.");
                            }
                        }
                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la clasificacion: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una clasificacion a eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea cancelar la accion actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvClasificacion_SelectionChanged(sender, e);

                txtDescrip.Enabled = false;
                txtClaveClasif.Enabled = false;
                dateTimePickerFechaCreacion.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvClasificacion.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtClaveClasif.Enabled = true;
            txtDescrip.Enabled = true;
            dateTimePickerFechaCreacion.Enabled = true;

            txtDescrip.Text = "";
            txtidClasificacion.Text = "";
            txtClaveClasif.Text = "";
            dateTimePickerFechaCreacion.Text = "";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvClasificacion.Enabled = false;
        }

        private void dgvClasificacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 1)
            {
                txtidClasificacion.Text = dgvClasificacion.SelectedRows[0].Cells["IDClasificacion"].Value.ToString();
                txtClaveClasif.Text = dgvClasificacion.SelectedRows[0].Cells["Clave"].Value.ToString();
                txtDescrip.Text = dgvClasificacion.SelectedRows[0].Cells["Descripcion"].Value.ToString();

                if (dgvClasificacion.SelectedRows[0].Cells["FecharHoraCreacion"].Value != DBNull.Value)
                {
                    dateTimePickerFechaCreacion.Value = Convert.ToDateTime(dgvClasificacion.SelectedRows[0].Cells["FecharHoraCreacion"].Value);
                }
            }
        }
    }
}
