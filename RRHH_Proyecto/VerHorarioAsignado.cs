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
    public partial class VerHorarioAsignado : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;
        public VerHorarioAsignado()
        {
            InitializeComponent();
            CargarDatosHorarioAsignado();

            // Deshabilitar campos y botones al inicio
            DeshabilitarCampos();
        }

        private void CargarDatosHorarioAsignado()
        {
            try
            {
                conexion.Open();
                string query = "SELECT IdHorario, IdNombre, Nombre, HEntrada, HSalida FROM Horario";
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

        private void VerHorarioAsignado_Load(object sender, EventArgs e)
        {

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
                            string query = "UPDATE Horario SET IdNombre = @IdNombre, Nombre = @Nombre, HEntrada = @HEntrada, HSalida = @HSalida WHERE IdHorario = @IdHorario";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@IdNombre", row["IdNombre"]);
                            cmd.Parameters.AddWithValue("@Nombre", row["Nombre"]);
                            cmd.Parameters.AddWithValue("@HEntrada", row["HEntrada"]);
                            cmd.Parameters.AddWithValue("@HSalida", row["HSalida"]);
                            cmd.Parameters.AddWithValue("@IdHorario", row["IdHorario"]);
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    conexion.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int idHorario = Convert.ToInt32(row.Cells["IdHorario"].Value);
                        string query = "DELETE FROM Horario WHERE IdHorario = @IdHorario";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@IdHorario", idHorario);
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

        private bool ValidarCampos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Nombre"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["Nombre"].Value.ToString()) ||
                    row.Cells["HEntrada"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["HEntrada"].Value.ToString()) ||
                    row.Cells["HSalida"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["HSalida"].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void HabilitarCampos()
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void DeshabilitarCampos()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }

}
