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
    public partial class VerAusencias : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;
        public VerAusencias()
        {
            InitializeComponent();

            CargarDatosAusencias();
            CargarEmpleados();
            CargarTiposDeAusencia();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void CargarDatosAusencias()
        {
            try
            {
                conexion.Open();
                string query = "SELECT Empleado_ID, IdAusencia, Empleado, FInicio, FFin FROM EmpleadoAusencia";
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

        private void CargarEmpleados()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, Nombre FROM Empleados", conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtEmpleados = new DataTable();
                dtEmpleados.Load(reader);
                comboBoxEmpleado.DataSource = dtEmpleados;
                comboBoxEmpleado.DisplayMember = "Nombre";
                comboBoxEmpleado.ValueMember = "ID";
                comboBoxEmpleado.SelectedIndex = -1; // ComboBox vacío al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarTiposDeAusencia()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdAusencia, TipoAusencia FROM Ausencia", conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtAusencias = new DataTable();
                dtAusencias.Load(reader);
                comboBoxAusencia.DataSource = dtAusencias;
                comboBoxAusencia.DisplayMember = "TipoAusencia";
                comboBoxAusencia.ValueMember = "IdAusencia";
                comboBoxAusencia.SelectedIndex = -1; // ComboBox vacío al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de ausencia: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void VerAusencias_Load(object sender, EventArgs e)
        {

        }



        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            comboBoxEmpleado.Enabled = true;
            comboBoxAusencia.Enabled = true;
            maskedTextBoxinicio.ReadOnly = false;
            maskedTextBoxFin.ReadOnly = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int empleadoId = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
                int ausenciaId = Convert.ToInt32(comboBoxAusencia.SelectedValue);
                string fechaInicio = maskedTextBoxinicio.Text;
                string fechaFin = maskedTextBoxFin.Text;

                DataGridViewRow row = dataGridView1.CurrentRow;

                try
                {
                    conexion.Open();

                    string query = "UPDATE EmpleadoAusencia SET Empleado_ID = @Empleado_ID, IdAusencia = @IdAusencia, FInicio = @FInicio, FFin = @FFin WHERE Empleado_ID = @OldEmpleado_ID AND IdAusencia = @OldIdAusencia";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Empleado_ID", empleadoId);
                    cmd.Parameters.AddWithValue("@IdAusencia", ausenciaId);
                    cmd.Parameters.AddWithValue("@FInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FFin", fechaFin);

                    // Los valores originales (antes de la edición) para identificar el registro
                    cmd.Parameters.AddWithValue("@OldEmpleado_ID", Convert.ToInt32(row.Cells["Empleado_ID"].Value));
                    cmd.Parameters.AddWithValue("@OldIdAusencia", Convert.ToInt32(row.Cells["IdAusencia"].Value));

                    cmd.ExecuteNonQuery();

                    // Actualiza los datos en el DataGridView
                    row.Cells["Empleado_ID"].Value = empleadoId;
                    row.Cells["IdAusencia"].Value = ausenciaId;
                    row.Cells["FInicio"].Value = fechaInicio;
                    row.Cells["FFin"].Value = fechaFin;

                    MessageBox.Show("Cambios guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                    dt.AcceptChanges();
                    dataGridView1.ReadOnly = true;
                    comboBoxEmpleado.Enabled = false;
                    comboBoxAusencia.Enabled = false;
                    maskedTextBoxinicio.ReadOnly = true;
                    maskedTextBoxFin.ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxEmpleado.SelectedValue = row.Cells["Empleado_ID"].Value;
                comboBoxAusencia.SelectedValue = row.Cells["IdAusencia"].Value;
                maskedTextBoxinicio.Text = row.Cells["FInicio"].Value.ToString();
                maskedTextBoxFin.Text = row.Cells["FFin"].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
