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
        //Aqui se instancia la clase de conexion 
        Conexion conexion = new Conexion();

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
        }

        private void CargarEmpleados()
        {
            // Consulta para seleccionar el nombre completo de los empleados
            string query = "SELECT ID, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";

            using (SqlCommand conexion_bd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(conexion_bd);
                DataTable empleados = new DataTable();
                adapter.Fill(empleados);

                // Configurar el ComboBox para mostrar solo el nombre completo
                cmb_Empleado.DisplayMember = "NombreCompleto";
                cmb_Empleado.ValueMember = "ID";
                cmb_Empleado.DataSource = empleados;

                conexion.CerrarConexion();

                // La conexión se cierra automáticamente al salir del bloque using
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

        private void cmb_TipoRetraso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_TipoRetraso.SelectedItem.ToString() == "Otros")
            {
                txt_OtroRetraso.Visible = true; // Muestra el TextBox
                txt_OtroRetraso.Focus();      // Opcional: Enfoca el TextBox
            }
            else
            {
                txt_OtroRetraso.Visible = false;  // Oculta el TextBox
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mb_Fecha_ValueChanged(object sender, EventArgs e)
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


            string TipoRetraso = cmb_TipoRetraso.Text;

            // Valida que no Haya un espacio en blanco o con un espacio
            if (string.IsNullOrWhiteSpace(TipoRetraso))

            {
                MessageBox.Show("Por favor, seleccione un tipo de retraso.", "Error");
                return;
            }


            //Aqui se obtiene el ID y nombre del empleado
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text; //Esto obtiene el nombre completo mostrado en el ComboBox

            // Verificar que se haya introducido una fecha
            if (string.IsNullOrWhiteSpace(TipoRetraso))
            {
                MessageBox.Show("La fecha introducida no es válida. Por favor, use el formato dd/MM/yyyy.", "Error");
                return;
            }

            // Conectar a la base de datos
            using (SqlConnection conexion_bd = conexion.AbrirConexion())
            {

                // Insertar el tipo de retraso si es "Otros"
                int idTipoRetraso = -1;
                if (TipoRetraso == "Otros")

                {
                    string descripcion = txt_OtroRetraso.Text;

                    // Verificar si la descripción ya existe
                    string queryCheck = "SELECT IdRetraso FROM Retraso WHERE TipoRetraso = @TipoRetraso";
                    SqlCommand comandoCheck = new SqlCommand(queryCheck, conexion_bd);
                    comandoCheck.Parameters.AddWithValue("@TipoRetraso", descripcion);
                    object result = comandoCheck.ExecuteScalar();

                    if (result == null)
                    {
                        // Insertar nuevo retraso
                        string queryInsertRetraso = "INSERT INTO Retraso (TipoRetraso) VALUES (@TipoRetraso); SELECT SCOPE_IDENTITY();";
                        SqlCommand comandoInsertRetraso = new SqlCommand(queryInsertRetraso, conexion_bd);
                        comandoInsertRetraso.Parameters.AddWithValue("@TipoRetraso", descripcion);
                        idTipoRetraso = Convert.ToInt32(comandoInsertRetraso.ExecuteScalar());
                    }
                    else
                    {
                        idTipoRetraso = Convert.ToInt32(result);
                    }
                }
                else
                {

                   

                    // Obtener el ID del tipo de retraso seleccionado
                    string queryTipoRetraso = "SELECT IdRetraso FROM Retraso WHERE TipoRetraso = @TipoRetraso";
                    SqlCommand comandoTipoRetraso = new SqlCommand(queryTipoRetraso, conexion_bd);
                    comandoTipoRetraso.Parameters.AddWithValue("@TipoRetraso", TipoRetraso);
                    idTipoRetraso = Convert.ToInt32(comandoTipoRetraso.ExecuteScalar());
                }

                // Insertar en la tabla TipoRetraso
                string queryInsertTipoRetraso = "INSERT INTO TipoRetraso (TipoRetraso) VALUES (@TipoRetraso)";
                SqlCommand comandoInsertTipoRetraso = new SqlCommand(queryInsertTipoRetraso, conexion_bd);

                comandoInsertTipoRetraso.Parameters.AddWithValue("@TipoRetraso", idTipoRetraso);

                comandoInsertTipoRetraso.ExecuteNonQuery();
                MessageBox.Show("Retraso agregado exitosamente.", "Éxito");


                //Captura el error de que si no se selecciona un tipo de retraso, osea que no se dejen campos vacios
                if (string.IsNullOrWhiteSpace(TipoRetraso))
                {
                    MessageBox.Show("Por favor, seleccione un tipo de retraso.", "Error");
                    return;
                }

         
             
                // Reinicia el formulario para que no se quede con los datos ya ingresados
                this.Controls.Clear();
                InitializeComponent();


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

        private void Retraso_Load(object sender, EventArgs e)
        {

        }
    }

}