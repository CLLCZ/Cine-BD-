using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CineConBD;

namespace PeliculasBD
{
    public partial class Venta : Form
    {
        private bool Editar = false;
        public Venta()
        {
            InitializeComponent();
            ObtenerDatosBD();
            llenarComboFuncion();
            llenarComboCliente();
            llenarComboTipoBoleto();
        }
        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    String consulta = "SELECT V.IDVenta, Cl.IDCliente, Cl.Nombre AS NombreCliente, F.IDFuncion, T.IDTipoBoleto, T.Clave AS TipoBoleto, V.Precio " +
                        "FROM Cine.dbo.Venta AS V INNER JOIN Cine.dbo.Cliente AS Cl ON V.IDCliente = Cl.IDCliente " +
                        "INNER JOIN Cine.dbo.Funcion AS F ON V.IDFuncion = F.IDFuncion INNER JOIN Cine.dbo.TipoBoleto AS T ON V.IDTipoBoleto = T.IDTipoBoleto;";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtVentas = new DataTable();
                    adapter.Fill(dtVentas);
                    dgvVenta.DataSource = dtVentas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

        }

        private void llenarComboFuncion()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDFuncion FROM Funcion";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtFuncion = new DataTable();
                    adapter.Fill(dtFuncion);
                    cbFuncion.DataSource = dtFuncion;
                    cbFuncion.DisplayMember = "IDFuncion";
                    cbFuncion.ValueMember = "IDFuncion";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de funciones.");
            }
        }

        private void llenarComboCliente()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDCliente, Nombre FROM Cliente";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtCliente = new DataTable();
                    adapter.Fill(dtCliente);
                    cbCliente.DataSource = dtCliente;
                    cbCliente.DisplayMember = "Nombre";
                    cbCliente.ValueMember = "IDCliente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de clientes.");
            }
        }

        private void llenarComboTipoBoleto()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDTipoBoleto, Clave FROM TipoBoleto";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtTipoBoleto = new DataTable();
                    adapter.Fill(dtTipoBoleto);
                    cbTipoBoleto.DataSource = dtTipoBoleto;
                    cbTipoBoleto.DisplayMember = "Clave";
                    cbTipoBoleto.ValueMember = "IDTipoBoleto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo de tipos de boletos.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            cbFuncion.Enabled = true;
            cbCliente.Enabled = true;
            cbTipoBoleto.Enabled = true;
            txtPrecio.Enabled = true;

            cbFuncion.Text = " ";
            cbCliente.Text = " ";
            cbTipoBoleto.Text = " ";
            txtidVenta.Text = " ";
            txtPrecio.Text = " ";

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvVenta.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            cbFuncion.Enabled = true;
            cbCliente.Enabled = true;
            cbTipoBoleto.Enabled = true;
            txtPrecio.Enabled = true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvVenta.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este genero?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Venta WHERE IDVenta = @IDVenta;";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDVenta", txtidVenta.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la venta.");
                            }
                        }
                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta a eliminar.");
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
                        string insertar = "INSERT INTO Cine.dbo.Venta (IDCliente, IDFuncion, IDTipoBoleto, Precio) VALUES (@IDCliente, @IDFuncion, @IDTipoBoleto, @Precio);";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        comando.Parameters.AddWithValue("@IDCliente", cbCliente.SelectedValue);
                        comando.Parameters.AddWithValue("@IDFuncion", cbFuncion.SelectedValue);
                        comando.Parameters.AddWithValue("@IDTipoBoleto", cbTipoBoleto.SelectedValue);
                        comando.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al insertar la venta.");
                        }
                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exito al insertar la venta.");
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Venta SET IDCliente = @IDCliente, IDFuncion = @IDFuncion, IDTipoBoleto = @IDTipoBoleto, Precio = @Precio WHERE IDVenta = @IDVenta;";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);
                        comando.Parameters.AddWithValue("@IDCliente", cbCliente.SelectedValue);
                        comando.Parameters.AddWithValue("@IDFuncion", cbFuncion.SelectedValue);
                        comando.Parameters.AddWithValue("@IDTipoBoleto", cbTipoBoleto.SelectedValue);
                        comando.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        comando.Parameters.AddWithValue("@IDVenta", txtidVenta.Text);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la venta.");
                        }

                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la venta: " + ex.Message);
                }
            }
            cbFuncion.Enabled = false;
            cbCliente.Enabled = false;
            cbTipoBoleto.Enabled = false;
            txtPrecio.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvVenta.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la accion actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvVenta_SelectionChanged(sender, e);

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvVenta.Enabled = true;
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

        private void dgvVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                txtidVenta.Text = dgvVenta.SelectedRows[0].Cells["IDVenta"].Value.ToString();
                cbCliente.SelectedValue = dgvVenta.SelectedRows[0].Cells["IDCliente"].Value;
                cbFuncion.SelectedValue = dgvVenta.SelectedRows[0].Cells["IDFuncion"].Value;
                cbTipoBoleto.SelectedValue = dgvVenta.SelectedRows[0].Cells["IDTipoBoleto"].Value;
                txtPrecio.Text = dgvVenta.SelectedRows[0].Cells["Precio"].Value.ToString();
            }
        }
    }
}
