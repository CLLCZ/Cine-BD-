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
    public partial class Pelicula : Form
    {
        private bool Editar = false;
        public Pelicula()
        {
            InitializeComponent();
            ObtenerDatosBD();
            llenarComboClasificacion();
            llenarComboGenero();
        }

        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    String consulta = "SELECT P.IDPelicula, P.NombrePelicula, P.Duracion, G.IDGenero, G.NombreGenero, C.IDClasificacion, "
                        + "C.Clave AS ClaveClasificacion FROM Cine.dbo.Pelicula AS P INNER JOIN Cine.dbo.Genero AS G ON "
                        + "P.IDGenero = G.IDGenero INNER JOIN Cine.dbo.Clasificacion AS C ON P.IDClasificacion = C.IDClasificacion";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtPelicula = new DataTable();
                    adapter.Fill(dtPelicula);

                    dgvPelicula.DataSource = dtPelicula;
                    dgvPelicula.Columns["IDGenero"].Visible = false;
                    dgvPelicula.Columns["IDClasificacion"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }


        private void llenarComboGenero()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDGenero, NombreGenero FROM Cine.dbo.Genero";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtGenero = new DataTable();
                    adapter.Fill(dtGenero);

                    cbGenero.DataSource = dtGenero;
                    cbGenero.ValueMember = "IDGenero";
                    cbGenero.DisplayMember = "NombreGenero";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de género: " + ex.Message);
            }
        }

        private void llenarComboClasificacion()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDClasificacion, Clave FROM Cine.dbo.Clasificacion";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtClasificacion = new DataTable();
                    adapter.Fill(dtClasificacion);

                    cbClasificacion.DataSource = dtClasificacion;
                    cbClasificacion.ValueMember = "IDClasificacion";
                    cbClasificacion.DisplayMember = "Clave";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de clasificación: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtduracion.Enabled = true;
            cbClasificacion.Enabled = true;
            cbGenero.Enabled = true;
            txtnombrePelicula.Enabled = true;

            txtduracion.Text = "";
            cbClasificacion.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            txtidPelicula.Text = "";
            txtnombrePelicula.Text = "";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvPelicula.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtduracion.Enabled = true;
            cbClasificacion.Enabled = true;
            cbGenero.Enabled = true;
            txtnombrePelicula.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvPelicula.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPelicula.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta película?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Pelicula WHERE IDPelicula = @IDPelicula";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDPelicula", txtidPelicula.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Éxito al eliminar la película.");
                            }
                        }
                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la película: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una película a eliminar.");
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
                        string insertar = "INSERT INTO Cine.dbo.Pelicula (NombrePelicula, Duracion, IDGenero, IDClasificacion) " +
                                          "VALUES (@NombrePelicula, @Duracion, @IDGenero, @IDClasificacion)";

                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@NombrePelicula", txtnombrePelicula.Text.Trim());
                        comando.Parameters.AddWithValue("@Duracion", txtduracion.Text.Trim());
                        comando.Parameters.AddWithValue("@IDGenero", cbGenero.SelectedValue);
                        comando.Parameters.AddWithValue("@IDClasificacion", cbClasificacion.SelectedValue);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al insertar la película.");
                        }
                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la película: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Pelicula SET NombrePelicula = @NombrePelicula, " +
                                            "Duracion = @Duracion, IDGenero = @IDGenero, IDClasificacion = @IDClasificacion " +
                                            "WHERE IDPelicula = @IDPelicula";

                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@IDPelicula", txtidPelicula.Text.Trim());
                        comando.Parameters.AddWithValue("@NombrePelicula", txtnombrePelicula.Text.Trim());
                        comando.Parameters.AddWithValue("@Duracion", txtduracion.Text.Trim());
                        comando.Parameters.AddWithValue("@IDGenero", cbGenero.SelectedValue);
                        comando.Parameters.AddWithValue("@IDClasificacion", cbClasificacion.SelectedValue);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al actualizar la película.");
                        }
                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la película: " + ex.Message);
                }
            }

            txtduracion.Enabled = false;
            cbClasificacion.Enabled = false;
            cbGenero.Enabled = false;
            txtnombrePelicula.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvPelicula.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvPelicula_SelectionChanged(sender, e);

                txtduracion.Enabled = false;
                cbClasificacion.Enabled = false;
                cbGenero.Enabled = false;
                txtnombrePelicula.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvPelicula.Enabled = true;
            }
        }

        private void dgvPelicula_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPelicula.SelectedRows.Count == 1)
            {
                txtidPelicula.Text = dgvPelicula.SelectedRows[0].Cells["IDPelicula"].Value.ToString();
                txtnombrePelicula.Text = dgvPelicula.SelectedRows[0].Cells["NombrePelicula"].Value.ToString();
                txtduracion.Text = dgvPelicula.SelectedRows[0].Cells["Duracion"].Value.ToString();

                cbGenero.SelectedValue = dgvPelicula.SelectedRows[0].Cells["IDGenero"].Value;
                cbClasificacion.SelectedValue = dgvPelicula.SelectedRows[0].Cells["IDClasificacion"].Value;
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
    }
}
