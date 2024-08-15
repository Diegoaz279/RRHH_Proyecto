using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RRHH_Proyecto
{
    public partial class VerHorasExtras : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;

        public VerHorasExtras()
        {
            InitializeComponent();
            CargarDatosHorasExtras();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void CargarDatosHorasExtras()
        {
            using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT IdTrabajoExtrabLaboral, DescripcionTrabajo, HInicio, HFin, Empleado_ID FROM TrabExtraboLaboral";
                    adaptador = new SqlDataAdapter(query, conexion);
                    dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void VerHorasExtras_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) // Botón Eliminar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
                {
                    try
                    {
                        conexion.Open();
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["IdTrabajoExtrabLaboral"].Value);
                            string query = "DELETE FROM TrabExtraboLaboral WHERE IdTrabajoExtrabLaboral = @IdTrabajoExtrabLaboral";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@IdTrabajoExtrabLaboral", id);
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
            }
        }

       
        private void button3_Click(object sender, EventArgs e) // Botón Guardar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    try
                    {
                        using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
                        {
                            conexion.Open();

                            int idTrabajoExtrabLaboral = Convert.ToInt32(row.Cells["IdTrabajoExtrabLaboral"].Value);
                            string descripcionTrabajo = row.Cells["DescripcionTrabajo"].Value.ToString();
                            string hInicio = row.Cells["HInicio"].Value.ToString();
                            string hFin = row.Cells["HFin"].Value.ToString();

                            string query = "UPDATE TrabExtraboLaboral SET DescripcionTrabajo = @DescripcionTrabajo, HInicio = @HInicio, HFin = @HFin WHERE IdTrabajoExtrabLaboral = @IdTrabajoExtrabLaboral";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@DescripcionTrabajo", descripcionTrabajo);
                            cmd.Parameters.AddWithValue("@HInicio", hInicio);
                            cmd.Parameters.AddWithValue("@HFin", hFin);
                            cmd.Parameters.AddWithValue("@IdTrabajoExtrabLaboral", idTrabajoExtrabLaboral);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cambios guardados correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                    }
                }

                // Refrescar el DataGridView
                CargarDatosHorasExtras();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para guardar.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
