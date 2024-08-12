using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RRHH_Proyecto
{
    public partial class Consulta_empleado : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        SqlDataAdapter adaptador;
        SqlCommandBuilder commandBuilder;
        DataTable dt;

        public Consulta_empleado()
        {
            InitializeComponent();
            CargarDatos();
            CargarCargos();

            // Desactivar edición en DataGridView al inicio
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void CargarDatos()
        {
            conexion.Open();
            adaptador = new SqlDataAdapter("SELECT * FROM Empleados", conexion);
            commandBuilder = new SqlCommandBuilder(adaptador);
            dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            maskedTxtCedula.Clear();
            maskedtxtTelefono.Clear();
            comboBoxCargo.SelectedIndex = -1;
        }

        private void CargarCargos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Cargo FROM Empleados", conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCargo.Items.Add(reader["Cargo"].ToString());
            }
            conexion.Close();
        }

        private void BuscarDatos()
        {
            DataView dv = dt.DefaultView;
            string cargoFiltro = comboBoxCargo.SelectedItem != null ? comboBoxCargo.SelectedItem.ToString() : "";

            string filtro = string.Format("Nombre LIKE '%{0}%' AND Cedula LIKE '%{1}%' AND Cargo LIKE '%{2}%' AND Telefono LIKE '%{3}%'",
                                          txtNombre.Text.Trim().Replace("'", "''"),
                                          maskedTxtCedula.Text.Replace("-", "").Trim(),
                                          cargoFiltro,
                                          maskedtxtTelefono.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Trim());

            dv.RowFilter = filtro;
            dataGridView1.DataSource = dv.ToTable();
        }


        private void btnEditar_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar los cambios en la base de datos
                adaptador.Update(dt);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

   
        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            BuscarDatos();
            LimpiarCampos();
        }



        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {

            if (dt.GetChanges() != null)
            {
                try
                {
                    // Guardar los cambios en la base de datos
                    adaptador.Update(dt);
                    MessageBox.Show("Cambios guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay cambios para guardar.");//hola
            }
        }
    }
}
