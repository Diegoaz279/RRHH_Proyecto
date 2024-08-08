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
            // Consulta para seleccionar el nombre completo de los empleados
            string query = "SELECT Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";

            using (SqlConnection conexion_bd = conexion.AbrirConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion_bd);
                DataTable empleados = new DataTable();
                adapter.Fill(empleados);

                // Configurar el ComboBox para mostrar solo el nombre completo
                cmb_Empleado.DisplayMember = "NombreCompleto";
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
            // Verificar si se ha seleccionado un empleado
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            string TipoAusencia = cmb_TipoAusencia.Text;

            // Valida que no Haya un spacio en blanco o con un spacio
            if (string.IsNullOrWhiteSpace(TipoAusencia))
               
            {
                MessageBox.Show("Por favor, seleccione un tipo de ausencia.", "Error");
                return;
            }
            // Obtener datos del formulario
            string Empleado = cmb_Empleado.SelectedItem.ToString(); // Ajusta según cómo obtienes el CI
            string tipoAusencia = cmb_TipoAusencia.SelectedItem.ToString();
            DateTime inicioAusencia = dt_InicioAusencia.Value;
            DateTime finAusencia = dt_FinAusencia.Value;

            // Conectar a la base de datos
            using (SqlConnection conexion_bd = conexion.AbrirConexion())
            {
                // Insertar el tipo de ausencia si es "Otras"
                int idTipoAusencia = -1;
                if (tipoAusencia == "Otras")
                {
                    string descripcion = txt_OtraAusencia.Text;

                    // Verificar si la descripción ya existe
                    string queryCheck = "SELECT IdAusencia FROM Ausencia WHERE TipoAusencia = @TipoAusencia";
                    SqlCommand comandoCheck = new SqlCommand(queryCheck, conexion_bd);
                    comandoCheck.Parameters.AddWithValue("@TipoAusencia", descripcion);
                    object result = comandoCheck.ExecuteScalar();

                    if (result == null)
                    {
                        // Insertar nueva ausencia
                        string queryInsertAusencia = "INSERT INTO Ausencia (TipoAusencia) VALUES (@TipoAusencia); SELECT SCOPE_IDENTITY();";
                        SqlCommand comandoInsertAusencia = new SqlCommand(queryInsertAusencia, conexion_bd);
                        comandoInsertAusencia.Parameters.AddWithValue("@TipoAusencia", descripcion);
                        idTipoAusencia = Convert.ToInt32(comandoInsertAusencia.ExecuteScalar());
                    }
                    else
                    {
                        idTipoAusencia = Convert.ToInt32(result);
                    }
                }
                else
                {
                    // Obtener el ID del tipo de ausencia seleccionado
                    string queryTipoAusencia = "SELECT IdAusencia FROM Ausencia WHERE TipoAusencia = @TipoAusencia";
                    SqlCommand comandoTipoAusencia = new SqlCommand(queryTipoAusencia, conexion_bd);
                    comandoTipoAusencia.Parameters.AddWithValue("@TipoAusencia", tipoAusencia);
                    idTipoAusencia = Convert.ToInt32(comandoTipoAusencia.ExecuteScalar());
                }

                // Insertar en la tabla EmpleadoAusencia
                string queryInsertEmpleadoAusencia = "INSERT INTO EmpleadoAusencia (Empleado, FInicio, FFin) VALUES (@Empleado, @FInicio, @FFin)";
                SqlCommand comandoInsertEmpleadoAusencia = new SqlCommand(queryInsertEmpleadoAusencia, conexion_bd);
                comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@Empleado", Empleado);

                comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FInicio", inicioAusencia);
                comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FFin", finAusencia);

                comandoInsertEmpleadoAusencia.ExecuteNonQuery();
                MessageBox.Show("Ausencia agregada exitosamente.", "Éxito");

                // Cerrar la conexión
                conexion.CerrarConexion();
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
