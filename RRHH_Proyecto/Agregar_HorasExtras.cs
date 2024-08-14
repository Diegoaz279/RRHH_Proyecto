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

namespace RRHH_Proyecto
{
    public partial class Agregar_HorasExtras : Form
    {
        Conexion0 conexion = new Conexion0();
        public Agregar_HorasExtras()
        {
            InitializeComponent();
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
        private void btn_Canclar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Agregar_HorasExtras_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Captura el error de que si no se selecciona un empleado, osea que no se dejen campos vacios
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            string hentrada = masked_Hentrada.Text;
            string hsalida = masked_Hsalida.Text;
            string descripcion = txt_DescripcionTrabajo.Text;
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text; //Esto obtiene el nombre completo mostrado en el ComboBox

            if (string.IsNullOrWhiteSpace(hentrada) || string.IsNullOrWhiteSpace(hsalida) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos Los Campos son Obligatorios.", "Error");
                return;

            }
        
            

            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;
            try
            {
                conexion_bd = conexion.GetConnection();

                string query = "INSERT INTO TrabExtraboLaboral (DescripcionTrabajo, HInicio, HFin, Empleado_ID, Empleado) VALUES (@Descripcion, @HoInicio, @HoFin, @EmpleadoID, @Empleado)";
                SqlCommand comando = new SqlCommand(query, conexion_bd);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@HoInicio", hentrada);
                comando.Parameters.AddWithValue("@HoFin", hsalida);
                comando.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                comando.Parameters.AddWithValue("@Empleado", empleadoNombre);

                comando.ExecuteNonQuery();
                MessageBox.Show("Hora Extra agregada exitosamente.", "Éxito");

                //cierra el formulario
                this.Dispose();
            }

            catch (Exception ex)
            {   
                //muestra el error por el cual no se pudo guardar la hora extra
                MessageBox.Show($"Error al agregar la Hora extra: {ex.Message}", "Error");
            }

            finally
            {
                //cierre de conexion
                conexion.CloseConnection(); 
            }



        }
    }
}
