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
        //Aqui se instancia la clase de conexion 
        Conexion0 conexion = new Conexion0();

        //Aqui se iniziliazan los componentes
        public Agregar_Ausencia()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Esto es para que si maxzimizamos la ventana se quede en el area de tabajo

        }

        //Evento Load del formulario, aqui se le dice que cuando inicie el formulario el Combobox inicie sin valor, osea en sin nada seleccionado
        private void Agregar_Ausencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
        }

        //Esto es para que cargue los empleados que hay en la tabla empleados en sql y te lo muestre en el combobox empleado
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



        //Evento del combobox tipo ausencia, aqui hacemos que si se lecciona la opcion Otras pues aparezca el text box Otro Ausencia, que es por si el usuario queire ingresar otro tipo de ausencia detallada
        private void cmb_TipoAusencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aqui se verifica si el valor seleccionado es nulo
            if (cmb_TipoAusencia.SelectedItem != null)
            {
                //Aqui verificamos si el tipo de ausencia seleccionado es la opcion Otras
                if (cmb_TipoAusencia.SelectedItem.ToString() == "Otras")
                {
                    txt_OtraAusencia.Visible = true; //Muestra el textBox para que el usuario ingrese un tipo de ausencia personalizado
                    txt_OtraAusencia.Focus(); //Enfoca el Textbox
                }
                else
                {
                    txt_OtraAusencia.Visible = false; //Oculta el textbox si el tipo de ausencia no es "Otras"
                    txt_OtraAusencia.Text = ""; //Limpia el textbox si se selecciona un tipo de ausencia diferente
                }
            }
        }



        //Evento click del boton agregar, em este apartado se hace todo para que a la hora del darle ingresar una ausencia se haga la conexion y todo lo que se necesite
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Captura el error de que si no se selecciona un empleado, osea que no se dejen campos vacios
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            //Aqui se determina el tipo de ausencia a insertar
            string TipoAusencia;
            if (cmb_TipoAusencia.SelectedItem.ToString() == "Otras" && !string.IsNullOrWhiteSpace(txt_OtraAusencia.Text))
            {
                TipoAusencia = txt_OtraAusencia.Text; //Usa el texto personalizado si se selecciono  la opcion otra
            }
            else
            {
                TipoAusencia = cmb_TipoAusencia.Text; //Usa el tipo de ausencia seleccionado del ComboBox
            }

            //Captura el error de que si no se selecciona un tipo de ausencia, osea que no se dejen campos vacios
            if (string.IsNullOrWhiteSpace(TipoAusencia))
            {
                MessageBox.Show("Por favor, seleccione un tipo de ausencia.", "Error");
                return;
            }

            //Aqui se obtiene el ID y nombre del empleado
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text; //Esto obtiene el nombre completo mostrado en el ComboBox

            //Obtiene las fechas como texto desde los maskedtextbox
            string inicioAusencia = mb_FechaInicio.Text;
            string finAusencia = mb_FechaFinal.Text;

            //Aqui se instancia la clase de conexion y la almacenamos en una variable
            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            try
            {
                conexion_bd = conexion.GetConnection();

                // Insertar el tipo de ausencia en la tabla Ausencia
                string queryInsertAusencia = "INSERT INTO Ausencia (TipoAusencia) VALUES (@TipoAusencia); SELECT SCOPE_IDENTITY();";
                SqlCommand comandoInsertAusencia = new SqlCommand(queryInsertAusencia, conexion_bd);
                comandoInsertAusencia.Parameters.AddWithValue("@TipoAusencia", TipoAusencia);
                int idTipoAusencia = Convert.ToInt32(comandoInsertAusencia.ExecuteScalar());

                if (idTipoAusencia > 0)
                {
                    // Insertar en la tabla EmpleadoAusencia, incluyendo el nombre del empleado
                    string queryInsertEmpleadoAusencia = "INSERT INTO EmpleadoAusencia (Empleado_ID, IdAusencia, Empleado, FInicio, FFin) VALUES (@Empleado_ID, @IdAusencia, @Empleado, @FInicio, @FFin)";
                    SqlCommand comandoInsertEmpleadoAusencia = new SqlCommand(queryInsertEmpleadoAusencia, conexion_bd);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@Empleado_ID", empleadoID);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@IdAusencia", idTipoAusencia);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@Empleado", empleadoNombre);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FInicio", inicioAusencia);
                    comandoInsertEmpleadoAusencia.Parameters.AddWithValue("@FFin", finAusencia);

                    comandoInsertEmpleadoAusencia.ExecuteNonQuery();
                    MessageBox.Show("Ausencia agregada exitosamente.", "Éxito");

                    // Reinicia el formulario para que no se quede con los datos ya ingresados
                    this.Controls.Clear();
                    InitializeComponent();
                }
                else ////Esto muestra un mensaje de error si no se pudo obtener el ID del tipo de ausencia
                {
                    MessageBox.Show("Error al obtener el Id del tipo de ausencia.", "Error");
                }
            }
            catch (Exception ex)  //Esto muestra un mensaje de error si ocurre una excepcion durante el proceso del try
            {
                MessageBox.Show($"Error al agregar ausencia: {ex.Message}", "Error");
            }
            finally// Finalmente cierre de la conexion 
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
