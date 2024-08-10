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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using RRHH_Proyecto;


namespace RRHH_Proyecto
{
    public partial class Agregar_Ausencia : Form
    {
        private Conexion conexion = new Conexion();
        public Agregar_Ausencia()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void Agregar_Ausencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
        }

        private void CargarEmpleados()
        {
            // Consulta para seleccionar el ID y el nombre completo de los empleados
            string query = "SELECT ID, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";

            using (SqlConnection conexion_bd = conexion.AbrirConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion_bd);
                DataTable empleados = new DataTable();
                adapter.Fill(empleados);

                // Configurar el ComboBox para mostrar el nombre completo y almacenar el ID
                cmb_Empleado.DisplayMember = "NombreCompleto";
                cmb_Empleado.ValueMember = "ID"; // Esto guarda el ID pero muestra el nombre completo
                cmb_Empleado.DataSource = empleados;

                conexion.CerrarConexion();
            }
        }


        //Configuracion de los botones de cerrar, minimizar, maximizar
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void cmb_TipoAusencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TipoAusencia.SelectedItem.ToString() == "Otras")
            {
                txt_OtraAusencia.Visible = true; // Muestra el TextBox
                txt_OtraAusencia.Focus(); // Opcional: Enfoca el TextBox
            }
            else
            {
                txt_OtraAusencia.Visible = false; // Oculta el TextBox
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dt_FinAusencia_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            string TipoAusencia = cmb_TipoAusencia.Text;

            if (string.IsNullOrWhiteSpace(TipoAusencia))
            {
                MessageBox.Show("Por favor, seleccione un tipo de ausencia.", "Error");
                return;
            }

            int empleadoID = (int)cmb_Empleado.SelectedValue; // Obtiene el ID del empleado seleccionado
            DateTime inicioAusencia = mb_FechaInicio.tex;
            DateTime finAusencia = dt_FinAusencia.Value;

            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            try
            {
                conexion_bd = conexion.GetConnection();

                // Insertar directamente el tipo de ausencia ingresado
                string queryInsertAusencia = "INSERT INTO Ausencia (TipoAusencia) VALUES (@TipoAusencia); SELECT SCOPE_IDENTITY();";
                SqlCommand comandoInsertAusencia = new SqlCommand(queryInsertAusencia, conexion_bd);
                comandoInsertAusencia.Parameters.AddWithValue("@TipoAusencia", TipoAusencia);
                int idTipoAusencia = Convert.ToInt32(comandoInsertAusencia.ExecuteScalar());

                // Verifica que idTipoAusencia sea válido antes de insertar
                if (idTipoAusencia > 0)
                {
                    // Insertar en la tabla EmpleadoAusencia
                    string queryInsertEmpleadoAusencia = "INSERT INTO EmpleadoAusencia (Empleado_ID, IdAusencia, FInicio, FFin) VALUES (@Empleado_ID, @IdAusencia, @FInicio, @FFin)";
                    SqlCommand comandoInsertEmpleadoAusencia = new SqlCommand(queryInsertEmpleadoAusencia, conexion_bd);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@Empleado_ID", empleadoID);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@IdAusencia", idTipoAusencia);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FInicio", inicioAusencia);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FFin", finAusencia);

                    comandoInsertEmpleadoAusencia.ExecuteNonQuery();
                    MessageBox.Show("Ausencia agregada exitosamente.", "Éxito");

                    // Limpiar campos después de agregar la ausencia
                    cmb_Empleado.SelectedIndex = -1;
                    cmb_TipoAusencia.SelectedIndex = -1;
                    txt_OtraAusencia.Clear();
                    dt_InicioAusencia.Value = DateTime.Now;
                    dt_FinAusencia.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Error al obtener el Id del tipo de ausencia.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar ausencia: {ex.Message}", "Error");
            }
            finally
            {
                conexion.CloseConnection();
            }

        }

        private void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_OtraAusencia_Enter(object sender, EventArgs e)
        {
            if (txt_OtraAusencia.Text == "MOTIVO DE AUSENCIA")
            {
                txt_OtraAusencia.Text = "";
                txt_OtraAusencia.ForeColor = Color.DimGray;
            }
        }

        private void txt_OtraAusencia_Leave(object sender, EventArgs e)
        {
            if (txt_OtraAusencia.Text == "")
            {
                txt_OtraAusencia.Text = "MOTIVO DE AUSENCIA";
                txt_OtraAusencia.ForeColor = Color.DimGray;
            }
        }

        private void txt_OtraAusencia_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
