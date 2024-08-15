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
                // Selecciona solo las columnas que existen en la tabla
                string query = "SELECT IdTipoRetraso, TipoDeRetraso FROM TipoRetraso";
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
            // Habilitar la edición en el DataGridView
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = true;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = column.Name == "ID"; // Configurar solo la columna ID como no editable
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT IdTipoRetraso, TipoDeRetraso FROM TipoRetraso";
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
                            string query = "UPDATE TipoRetraso SET TipoDeRetraso = @TipoDeRetraso WHERE IdTipoRetraso = @IdTipoRetraso";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@IdTipoRetraso", row["IdTipoRetraso"]);
                            cmd.Parameters.AddWithValue("@TipoDeRetraso", row["TipoDeRetraso"]);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
