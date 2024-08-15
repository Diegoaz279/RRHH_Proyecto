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

    public partial class Agregar_Retraso : Form
    {
        // Instancia de la clase de conexión
        Conexion0 conexion = new Conexion0();


        //Aqui se iniziliazan los componentes
        public Agregar_Retraso()
        {
            // Esto es para que si maxzimizamos la ventana se quede en el area de tabajo
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Agregar_Retraso_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
            cmb_TipoRetraso.SelectedIndex = -1; // Asegura que el ComboBox esté vacío al inicio
        }

        private void CargarEmpleados()
        {
            string query = "SELECT ID, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";

            using (SqlCommand comando = new SqlCommand(query, conexion.GetConnection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable empleados = new DataTable();
                adapter.Fill(empleados);

                cmb_Empleado.DisplayMember = "NombreCompleto";
                cmb_Empleado.ValueMember = "ID";
                cmb_Empleado.DataSource = empleados;
            }
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Retraso_Load(object sender, EventArgs e)
        {
            label2.Focus();
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
        }

       
        private void cmb_TipoRetraso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_TipoRetraso.SelectedItem != null)
            {
                if (cmb_TipoRetraso.SelectedItem.ToString() == "Otros") 
                {
                    txt_OtroRetraso.Visible = true; // Muestra el TextBox para tipo de retraso personalizado
                    txt_OtroRetraso.Focus(); // Enfoca el TextBox
                }
           
                else
                {
                    txt_OtroRetraso.Visible = false; // Oculta el TextBox si no se selecciona "Otros"
                    txt_OtroRetraso.Text = ""; // Limpia el TextBox
                }
            }    
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            //Aqui se determina el tipo de ausencia a insertar
            string TipoRetraso;
            if (cmb_TipoRetraso.SelectedItem.ToString() == "Otras" && !string.IsNullOrWhiteSpace(txt_OtroRetraso.Text))
            {
                TipoRetraso = txt_OtroRetraso.Text; //Usa el texto personalizado si se selecciono  la opcion otra
            }
            else
            {
                TipoRetraso = cmb_TipoRetraso.Text; //Usa el tipo de ausencia seleccionado del ComboBox
            }

            //Captura el error de que si no se selecciona un tipo de ausencia, osea que no se dejen campos vacios
            if (string.IsNullOrWhiteSpace(TipoRetraso))
            {
                MessageBox.Show("Por favor, seleccione un tipo de Retraso.", "Error");
                return;
            }

            // Aqui se obtiene el ID y nombre del empleado
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text; //Esto obtiene el nombre completo mostrado en el ComboBox

            //Obtiene las fechas como texto desde los maskedtextbox
            string fecha = mb_Fecha.Text;
            string Oservacion = txt_Observacion.Text;
            string minutos = maskedText_Minutos.Text;
           

            //Aqui se instancia la clase de conexion y la almacenamos en una variable
            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            try
            {
                conexion_bd = conexion.GetConnection();

                // Inserción del tipo de retraso en la tabla TipoRetraso
                string queryInsertTipoRetraso = "INSERT INTO TipoRetraso (TipoDeRetraso) VALUES (@TipoDeRetraso); SELECT SCOPE_IDENTITY();";
                SqlCommand comandoInsertTipoRetraso = new SqlCommand(queryInsertTipoRetraso, conexion_bd);
                comandoInsertTipoRetraso.Parameters.AddWithValue("@TipoDeRetraso", TipoRetraso);
                int idTipoRetraso = Convert.ToInt32(comandoInsertTipoRetraso.ExecuteScalar());

                if (idTipoRetraso > 0)
                {
                    // Inserción en la tabla Retraso, incluyendo la información del empleado
                    string queryInsertRetraso = "INSERT INTO Retraso (ID, Empleado, IdTipoRetraso, Fecha, Minutos, Observacion) VALUES (@ID, @Empleado, @IdTipoRetraso, @Fecha, @Minutos, @Observacion)";
                    SqlCommand comandoInsertRetraso = new SqlCommand(queryInsertRetraso, conexion_bd);

                    // Asigna los valores a los parámetros
                    comandoInsertRetraso.Parameters.AddWithValue("@ID", empleadoID); // ID del empleado
                    comandoInsertRetraso.Parameters.AddWithValue("@Empleado", empleadoNombre); // Nombre completo del empleado
                    comandoInsertRetraso.Parameters.AddWithValue("@IdTipoRetraso", idTipoRetraso); // ID del tipo de retraso
                    comandoInsertRetraso.Parameters.AddWithValue("@Fecha", mb_Fecha.Text); // Fecha desde MaskedTextBox
                    comandoInsertRetraso.Parameters.AddWithValue("@Minutos", minutos); // Ajusta este valor según sea necesario
                    comandoInsertRetraso.Parameters.AddWithValue("@Observacion", Oservacion); // Observación o motivo del retraso

                    // Ejecuta la consulta para insertar el registro en la base de datos
                    comandoInsertRetraso.ExecuteNonQuery();
                    MessageBox.Show("Retraso agregado exitosamente.", "Éxito");

                    // Reinicia el formulario para que no se quede con los datos ya ingresados
                    this.Dispose();
                }

                else 
                {
                    MessageBox.Show("Error al obtener el Id del tipo de retraso.", "Error");
                }

            }
            catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar retraso: {ex.Message}", "Error");
                }
                finally
                {
                    conexion.CloseConnection();
                }
            
        }



        private int ObtenerIdTipoRetraso(SqlConnection conexion_bd, string descripcionRetraso)
        {
            string query = "SELECT IdTipoRetraso FROM TipoRetraso WHERE TipoDeRetraso = @TipoDeRetraso";
            using (SqlCommand comando = new SqlCommand(query, conexion_bd))
            {
                comando.Parameters.AddWithValue("@TipoDeRetraso", descripcionRetraso);
                object result = comando.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        

      

        private void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void txt_OtroRetraso_Enter(object sender, EventArgs e)
        {
            if (txt_OtroRetraso.Text == "MOTIVO DE RETRASO")
            {
                txt_OtroRetraso.Text = "";
                txt_OtroRetraso.ForeColor = Color.DimGray;
            }
        }

        private void txt_OtroRetraso_Leave(object sender, EventArgs e)
        {
            if (txt_OtroRetraso.Text == "")
            {
                txt_OtroRetraso.Text = "MOTIVO DE RETRASO";
                txt_OtroRetraso.ForeColor = Color.DimGray;
            }
        }
    }

}