using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH_Proyecto
{
    public partial class Consulta_Retrasos : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        DataTable dt;
        public Consulta_Retrasos()
        {
            InitializeComponent();
            CargarDatosRetraso();
            CargarTiposDeRetraso();
            CargarEmpleados();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.SelectedIndex = -1;
            comboBoxEmpleado.SelectedIndex = -1;
        }

        private void CargarEmpleados()
        {
            using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los empleados: " + ex.Message);
                }
            }
        }
        private void CargarDatosRetraso()
        {
            using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT IdRetraso, ID, IdTipoRetraso, Fecha, Minutos, Observacion FROM Retraso";
                    adaptador = new SqlDataAdapter(query, conexion);

                    dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Configuración para permitir edición
                    dataGridView1.AllowUserToAddRows = false; // No permitir agregar filas nuevas
                    dataGridView1.AllowUserToDeleteRows = false; // No permitir eliminar filas
                    dataGridView1.ReadOnly = false; // Permitir edición
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }


        private void CargarTiposDeRetraso()
        {
            using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
            {
                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IdTipoRetraso, TipoDeRetraso FROM TipoRetraso", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtTipoRetraso = new DataTable();
                    dtTipoRetraso.Load(reader);
                    comboBox1.DataSource = dtTipoRetraso;
                    comboBox1.DisplayMember = "TipoDeRetraso";
                    comboBox1.ValueMember = "IdTipoRetraso";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de retraso: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            comboBox1.SelectedIndex = -1;
            comboBoxEmpleado.SelectedIndex = -1;
            maskedTextBoxminutos.Clear();
            maskedTextBoxfecha.Clear();
            txtObservacion.Clear();
        }
        private void Consulta_Retrasos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Habilitar edición de celdas
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false; // No permitir agregar nuevas filas
            dataGridView1.AllowUserToDeleteRows = false; // 

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "ID" || column.Name == "IdRetraso" || column.Name == "IdTipoRetraso")
                {
                    column.ReadOnly = true; // No permitir la edición de los ID
                }
                else
                {
                    column.ReadOnly = false; // Permitir la edición de las demás columnas
                }
            }


            LimpiarCampos();
        }


    
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Guardar cambios cuando se termina de editar una celda
            btnGuardar.PerformClick(); // Simular clic en el botón de guardar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true"))
            {
                try
                {
                    conexion.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE Retraso SET ID = @ID, IdTipoRetraso = @IdTipoRetraso, Fecha = @Fecha, Minutos = @Minutos, Observacion = @Observacion WHERE IdRetraso = @IdRetraso";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@ID", row["ID"]);
                            cmd.Parameters.AddWithValue("@IdTipoRetraso", row["IdTipoRetraso"]);
                            cmd.Parameters.AddWithValue("@Fecha", row["Fecha"]);
                            cmd.Parameters.AddWithValue("@Minutos", row["Minutos"]);
                            cmd.Parameters.AddWithValue("@Observacion", row["Observacion"]);
                            cmd.Parameters.AddWithValue("@IdRetraso", row["IdRetraso"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cambios guardados correctamente.");
                    dt.AcceptChanges(); // Aceptar los cambios en el DataTable
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);

                }


            }

        }

        private void maskedTextBoxfecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
