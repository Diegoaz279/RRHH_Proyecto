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
    public partial class Ver_Departamento : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;

        public Ver_Departamento()
        {
            InitializeComponent();
            CargarDatosDepartamentos();
            DeshabilitarCampos();
        }

        private void CargarDatosDepartamentos()
        {
            try
            {
                conexion.Open();
                string query = "SELECT IdDpto, NombreDpto, IDJefe, NombreJefe, CorreoElectronicoDpto FROM Departamento";
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_Departamento_Load(object sender, EventArgs e)
        {

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
                            string query = "UPDATE Departamento SET NombreDpto = @NombreDpto, IDJefe = @IDJefe, NombreJefe = @NombreJefe, CorreoElectronicoDpto = @CorreoElectronicoDpto WHERE IdDpto = @IdDpto";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@NombreDpto", row["NombreDpto"]);
                            cmd.Parameters.AddWithValue("@IDJefe", row["IDJefe"]);
                            cmd.Parameters.AddWithValue("@NombreJefe", row["NombreJefe"]);
                            cmd.Parameters.AddWithValue("@CorreoElectronicoDpto", row["CorreoElectronicoDpto"]);
                            cmd.Parameters.AddWithValue("@IdDpto", row["IdDpto"]);
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
                        int idDpto = Convert.ToInt32(row.Cells["IdDpto"].Value);
                        string query = "DELETE FROM Departamento WHERE IdDpto = @IdDpto";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@IdDpto", idDpto);
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

        private bool ValidarCampos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["NombreDpto"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["NombreDpto"].Value.ToString()) ||
                    row.Cells["NombreJefe"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["NombreJefe"].Value.ToString()) ||
                    row.Cells["CorreoElectronicoDpto"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row.Cells["CorreoElectronicoDpto"].Value.ToString()))
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
    }
}
