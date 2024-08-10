using System;
using System.Collections;
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
    public partial class Agregar_Departamento : Form
    {
        Conexion0 conexion = new Conexion0();
        public Agregar_Departamento()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Esto es para que si maxzimizamos la ventana se quede en el area de tabajo
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Agregar_Departamento_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cb_Jefe.SelectedIndex = -1;
        }

        private void CargarEmpleados()
        {
            string query = "SELECT ID, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";

            using (SqlCommand comando = new SqlCommand(query, conexion.GetConnection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable empleados = new DataTable();
                adapter.Fill(empleados);

                cb_Jefe.DisplayMember = "NombreCompleto";
                cb_Jefe.ValueMember = "ID";
                cb_Jefe.DataSource = empleados;
            }
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            // Captura el error de que si no se selecciona un jefe, o sea, que no se dejen campos vacíos
            if (cb_Jefe.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Jefe al Departamento.", "Error");
                return;
            }

            // Aquí se obtiene el ID y nombre del jefe
            int JefeID = (int)cb_Jefe.SelectedValue;
            string JefeNombre = cb_Jefe.Text; // Esto obtiene el nombre completo mostrado en el ComboBox

            // Instanciar la clase de conexión y almacenarla en una variable
            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            string correodep = txt_CorreoDep.Text;
            string nombrede = txt_NomDepartamento.Text;

            // Valida que no haya un espacio en blanco o que esté vacío
            if (string.IsNullOrWhiteSpace(correodep) || string.IsNullOrWhiteSpace(nombrede))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error");
                return;
            }

            // Consulta para insertar un nuevo departamento
            string query = "INSERT INTO Departamento (NombreDpto, IDJefe, NombreJefe, CorreoElectronicoDpto) VALUES (@Departamento, @IDJefe, @NombreJefe, @CorreoDepart)";

            try
            {
                conexion_bd = conexion.GetConnection();

                using (SqlCommand comando = new SqlCommand(query, conexion_bd))
                {
                    comando.Parameters.AddWithValue("@Departamento", nombrede);
                    comando.Parameters.AddWithValue("@IDJefe", JefeID);
                    comando.Parameters.AddWithValue("@NombreJefe", JefeNombre); // Inserta el nombre del jefe
                    comando.Parameters.AddWithValue("@CorreoDepart", correodep);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Departamento registrado exitosamente.", "Éxito");

                    // Reinicia el formulario para que no se quede con los datos ya ingresados
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el Departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CloseConnection(); // Cierra la conexión
            }

        }

    }
}
