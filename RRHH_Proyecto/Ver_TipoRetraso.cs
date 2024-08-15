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
    public partial class Ver_TipoRetraso : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;

        public Ver_TipoRetraso()
        {
            InitializeComponent();
            CargarDatosTiposRetraso();
            ConfigurarDataGridView();
        }

        private void CargarDatosTiposRetraso()
        {
            try
            {
                conexion.Open();
                string query = "SELECT IdTipoRetraso, TipoDeRetraso, Tipo_Retraso FROM TipoRetraso";
                adaptador = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void ConfigurarDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false; // Evita la fila en blanco adicional
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_TipoRetraso_Load(object sender, EventArgs e)
        {

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
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
                        int idTipoRetraso = Convert.ToInt32(row.Cells["IdTipoRetraso"].Value);
                        string query = "DELETE FROM TipoRetraso WHERE IdTipoRetraso = @IdTipoRetraso";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@IdTipoRetraso", idTipoRetraso);
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
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    conexion.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE TipoRetraso SET TipoDeRetraso = @TipoDeRetraso, Tipo_Retraso = @Tipo_Retraso WHERE IdTipoRetraso = @IdTipoRetraso";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@IdTipoRetraso", row["IdTipoRetraso"]);
                            cmd.Parameters.AddWithValue("@TipoDeRetraso", row["TipoDeRetraso"]);
                            cmd.Parameters.AddWithValue("@Tipo_Retraso", row["Tipo_Retraso"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cambios guardados correctamente.");
                    dt.AcceptChanges();
                    dataGridView1.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            } 
        }
    }
}
