using CineConBD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PeliculasBD
{
    public partial class Funcion : Form
    {
        private bool Editar = false; 
       
        public Funcion()
        {
            InitializeComponent(); 
            ObtenerDatosBD();
            llenarComboPelicula();
            llenarComboSala();
        }
        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    String consulta = "SELECT F.IDFuncion, P.IDPelicula, P.NombrePelicula, S.IDSala, S.NumeroSala, F.Fecha, F.Hora FROM Cine.dbo.Funcion AS F " +
                        "INNER JOIN Cine.dbo.Pelicula AS P ON F.IDPelicula = P.IDPelicula INNER JOIN Cine.dbo.Sala AS S ON F.IDSala = S.IDSala"; ;
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtFuncion = new DataTable();
                    adapter.Fill(dtFuncion);
                    dgvFuncion.DataSource = dtFuncion;
                    dgvFuncion.Columns["IDPelicula"].Visible = false;  
                    dgvFuncion.Columns["IDSala"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

        }
        private void llenarComboPelicula()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDPelicula, NombrePelicula FROM Cine.dbo.Pelicula";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtPelicula = new DataTable();
                    adapter.Fill(dtPelicula);

                    cbPelicula.DataSource = dtPelicula;
                    cbPelicula.ValueMember = "IDPelicula";
                    cbPelicula.DisplayMember = "NombrePelicula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la información de película: " + ex.Message);
            }
        }

        private void llenarComboSala()
        {
            try
            {
                using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                {
                    sqlConn.Open();
                    string consulta = "SELECT IDSala, NumeroSala FROM Cine.dbo.Sala";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dtSala = new DataTable();
                    adapter.Fill(dtSala);

                    cbSala.DataSource = dtSala;
                    cbSala.ValueMember = "IDSala";
                    cbSala.DisplayMember = "NumeroSala";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la información de sala: " + ex.Message);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;

            cbPelicula.Enabled = true;
            cbSala.Enabled = true;  
            dateTimePickerFecha.Enabled = true;
            checkedListBoxHora.Enabled = true;

            txtidFuncion.Text = "";
            cbPelicula.Text = "";
            cbSala.Text = "";
            checkedListBoxHora.SelectedIndex = -1;
            dateTimePickerFecha.Value = DateTime.Now; 
             
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvFuncion.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            cbPelicula.Enabled= true;
            cbSala.Enabled= true;
            dateTimePickerFecha.Enabled= true;
            checkedListBoxHora.Enabled= true;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;
            btnObtener.Enabled = false;
            dgvFuncion.Enabled = false;
             
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFuncion.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar la función actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                        {
                            sqlConn.Open();
                            string consulta = "DELETE FROM Cine.dbo.Funcion WHERE IDFuncion = @IDFuncion;";
                            SqlCommand comando = new SqlCommand(consulta, sqlConn);
                            comando.Parameters.AddWithValue("@IDFuncion", txtidFuncion.Text);
                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados == 1)
                            {
                                MessageBox.Show("Exito al eliminar la función.");
                            }
                        }
                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exito al eliminar la función.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione una función para eliminar");
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
                        string insertar = "INSERT INTO Cine.dbo.Funcion (IDPelicula, IDSala, Fecha, Hora) VALUES (@IDPelicula, @IDSala, @Fecha, @Hora);";
                        string horaSeleccionada = "";
                        SqlCommand comando = new SqlCommand(insertar, sqlConn);
                        for (int i = 0; i < checkedListBoxHora.Items.Count; i++)
                        {
                            if (checkedListBoxHora.GetItemChecked(i))
                            {
                                horaSeleccionada = checkedListBoxHora.GetItemText(checkedListBoxHora.Items[i]);
                            }
                        }

                        comando.Parameters.AddWithValue("@IDPelicula", cbPelicula.SelectedValue);
                        comando.Parameters.AddWithValue("@IDSala", cbSala.SelectedValue);
                        comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                        comando.Parameters.AddWithValue("@Fecha", dateTimePickerFecha.Value);
                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al insertar la función.");
                        }

                    }
                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exito al insertar la función."); 
                }
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConn = Conexion.ObtenerConexion())
                    {
                        sqlConn.Open();
                        string actualizar = "UPDATE Cine.dbo.Funcion SET IDPelicula = @IDPelicula, IDSala = @IDSala, Fecha = @Fecha, Hora = @Hora WHERE IDFuncion = @IDFuncion;";
                        string horaSeleccionada = "";
                        SqlCommand comando = new SqlCommand(actualizar, sqlConn);  
                        for (int i = 0; i < checkedListBoxHora.Items.Count; i++)
                        {
                            if (checkedListBoxHora.GetItemChecked(i))
                            {
                                horaSeleccionada = checkedListBoxHora.GetItemText(checkedListBoxHora.Items[i]);
                            }
                        }

                        comando.Parameters.AddWithValue("@IDPelicula", cbPelicula.SelectedValue);
                        comando.Parameters.AddWithValue("@IDSala", cbSala.SelectedValue);
                        comando.Parameters.AddWithValue("@Fecha", dateTimePickerFecha.Value);
                        comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                        comando.Parameters.AddWithValue("@IDFuncion", txtidFuncion.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Exito al actualizar la función.");
                        }


                    }
                    ObtenerDatosBD();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al actualizar la función: " + ex.Message);
                }
            }
            cbPelicula.Enabled = false;  
            cbSala.Enabled = false;
            dateTimePickerFecha.Enabled = false;
            checkedListBoxHora.Enabled = false;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnObtener.Enabled = true;
            dgvFuncion.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la accion actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Editar = false;
                dgvFuncion_SelectionChanged(sender, e);

                cbPelicula.Enabled = false;
                cbSala.Enabled = false;
                dateTimePickerFecha.Enabled = false;
                checkedListBoxHora.Enabled = false;

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalir.Enabled = true;
                btnObtener.Enabled = true;
                dgvFuncion.Enabled = true;
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
        private void dgvFuncion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFuncion.SelectedRows.Count == 1)
            { 
                txtidFuncion.Text = dgvFuncion.SelectedRows[0].Cells["IDFuncion"].Value.ToString();
                cbPelicula.SelectedValue = dgvFuncion.SelectedRows[0].Cells["IDPelicula"].Value;
                cbSala.SelectedValue = dgvFuncion.SelectedRows[0].Cells["IDSala"].Value;
                 
                string hora = dgvFuncion.SelectedRows[0].Cells["Hora"].Value.ToString();
                 
                for (int i = 0; i < checkedListBoxHora.Items.Count; i++)
                {
                    string itemTexto = checkedListBoxHora.GetItemText(checkedListBoxHora.Items[i]);

                    if (itemTexto == hora)
                    {
                        checkedListBoxHora.SetItemChecked(i, true);  
                    }
                    else
                    {
                        checkedListBoxHora.SetItemChecked(i, false); 
                    }
                }
            }
        }
    }

}
