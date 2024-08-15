using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH_Proyecto
{
    public partial class Ver_MotivoPase : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;
        public Ver_MotivoPase()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false; // Evita la fila en blanco al inicio
            CargarDatosMotivoPase();

            // Deshabilitar edición de ID al inicio
            DeshabilitarCampos();
        }

        private void CargarDatosMotivoPase()
        {
            try
            {
                conexion.Open();
                string query = @"SELECT pe.IdPaseEmpleado, pe.ID, pe.Fecha, pe.HEnt, pe.HSal, pe.Clave, mp.MotivoPase 
                                 FROM PaseEmpleado pe
                                 JOIN MotivoPase mp ON pe.IdMotivoPase = mp.IdMotivoPase";
                adaptador = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

                // Deshabilitar edición de ID
                dataGridView1.Columns["IdPaseEmpleado"].ReadOnly = true;
                dataGridView1.Columns["ID"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_MotivoPase_Load(object sender, EventArgs e)
        {

        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    conexion.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int idPaseEmpleado = Convert.ToInt32(row.Cells["IdPaseEmpleado"].Value);
                        string query = "DELETE FROM PaseEmpleado WHERE IdPaseEmpleado = @IdPaseEmpleado";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@IdPaseEmpleado", idPaseEmpleado);
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                    MessageBox.Show("Registro(s) eliminado(s) correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    conexion.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string query = @"UPDATE PaseEmpleado 
                                             SET Fecha = @Fecha, HEnt = @HEnt, HSal = @HSal, Clave = @Clave 
                                             WHERE IdPaseEmpleado = @IdPaseEmpleado";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@Fecha", row["Fecha"]);
                            cmd.Parameters.AddWithValue("@HEnt", row["HEnt"]);
                            cmd.Parameters.AddWithValue("@HSal", row["HSal"]);
                            cmd.Parameters.AddWithValue("@Clave", row["Clave"]);
                            cmd.Parameters.AddWithValue("@IdPaseEmpleado", row["IdPaseEmpleado"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cambios guardados correctamente.");
                    dt.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                    DeshabilitarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
        }
        private bool ValidarCampos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Fecha"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["Fecha"].Value.ToString()) ||
                    row.Cells["HEnt"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["HEnt"].Value.ToString()) ||
                    row.Cells["HSal"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["HSal"].Value.ToString()) ||
                    row.Cells["Clave"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["Clave"].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void HabilitarCampos()
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["IdPaseEmpleado"].ReadOnly = true;
            dataGridView1.Columns["ID"].ReadOnly = true;
        }

        private void DeshabilitarCampos()
        {
            dataGridView1.ReadOnly = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
