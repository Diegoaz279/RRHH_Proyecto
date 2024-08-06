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
    public partial class Agregar_Empleado : Form
    {
        // Declaración de la clase de conexión
        private Conexion conexion = new Conexion();
        public Agregar_Empleado()
        {   
            InitializeComponent();
        }

        //APARTADO PARA QUE APAREZCAN Y DESAPAREZCAN LAS LETRAS DE INFO DE LOS TEXT BOX
        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
        }
        private void txt_Nombre_Leave(object sender, EventArgs e)
        {  
        }
        private void txt_Apellido_Enter(object sender, EventArgs e)
        {   
        }
        private void txt_Apellido_Leave(object sender, EventArgs e)
        { 
        }
        private void txt_Nacimiento_Enter(object sender, EventArgs e)
        { 
        }
        private void txt_Nacimiento_Leave(object sender, EventArgs e)
        {
        }
        private void txt_Correo_Enter(object sender, EventArgs e)
        {
        }
        private void txt_Correo_Leave(object sender, EventArgs e)
        {
        }

        //Evento Boton registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
             // Obtener valores de los TextBox
            int id;
            bool isIdValid = int.TryParse(mtb_Id.Text, out id); // Validar el ID
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string cedula = mtb_Cedula.Text;
            string lugarNacimiento = txt_Nacimiento.Text;
            string cargo = txt_Cargo.Text;
            string telefono = mtb_Telefono.Text;
            string correoElectronico = txt_Correo.Text;

            // Validaciones
            if (!isIdValid)
            {
                MessageBox.Show("El ID ingresado no es válido.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(lugarNacimiento) ||
                string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correoElectronico))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error");
                return;
            }

            // Consulta de inserción
            string query = "INSERT INTO Empleados (CI, Nombre, Apellido, Cédula, LugarNacimiento, Cargo, Telefono, CorreoElectronico) VALUES (@CI, @Nombre, @Apellido, @Cedula, @LugarNacimiento, @Cargo, @Telefono, @CorreoElectronico)";

            SqlConnection conexion_bd = null;
            try
            {
                // Llamada a tu método para abrir la conexión
                conexion_bd = conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(query, conexion_bd);
                comando.Parameters.AddWithValue("@CI", id); // Usar el valor ingresado en txt_Id
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters.AddWithValue("@LugarNacimiento", lugarNacimiento);
                comando.Parameters.AddWithValue("@Cargo", cargo);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado registrado exitosamente");

                // Reiniciar el formulario actual
                this.Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conexion_bd != null)
                {
                    // Llamada a tu método para cerrar la conexión
                    conexion.CerrarConexion();
                }
            }

        }

    
        private void Agregar_Empleado_Load(object sender, EventArgs e)
        {
        }


        // Comfiguracion de los botones Cerra, Maximizar, Cancelar y Minimizar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
