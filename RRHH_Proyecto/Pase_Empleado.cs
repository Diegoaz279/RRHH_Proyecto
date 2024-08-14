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

namespace RRHH_Proyecto
{
    public partial class Pase_Empleado : Form
    {
        Conexion0 conexion = new Conexion0();
        public Pase_Empleado()
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

        private void CargarTipoPase()
        {
            string query = "SELECT IdMotivoPase, MotivoPase AS MotivoPasee FROM MotivoPase";

            using (SqlCommand comando = new SqlCommand(query, conexion.GetConnection()))
            {
                SqlDataAdapter adapteer = new SqlDataAdapter(comando);
                DataTable motivopase = new DataTable();
                adapteer.Fill(motivopase);

                cmb_MotivoPase.DisplayMember = "MotivoPasee";
                cmb_MotivoPase.ValueMember = "IdMotivoPase";
                cmb_MotivoPase.DataSource = motivopase;
            }
        }

        private void Agregar_Horario_Load(object sender, EventArgs e)
        {
            CargarTipoPase();
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
            cmb_MotivoPase.SelectedIndex = -1;



        }
        private void btn_Canclar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Captura el error de que si no se selecciona un empleado, osea que no se dejen campos vacios
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            if (cmb_MotivoPase.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Motivo de Pase.", "Error");
                return;
            }

            //Aqui se obtiene el ID del empleado
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            int idmotivopase = (int)cmb_MotivoPase.SelectedValue;

            //Obtiene las fechas como texto desde los maskedtextbox
            string horaentrada = masked_Hentrada.Text;
            string horasalida = masked_Hsalida.Text;
            string fecha = masked_Fecha.Text;
            int clave = int.Parse(masked_Clave.Text);


            //Aqui se instancia la clase de conexion y la almacenamos en una variable
            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            try
            {
                conexion_bd = conexion.GetConnection();


                // Insertar en la tabla motivo pase
                string queryPase = "INSERT INTO PaseEmpleado (ID, Fecha, HEnt, HSal, Clave, IdMotivoPase) VALUES (@EmpleadoID, @Fecha, @Horaentrada, @HoraSalida, @Clave, @IdMotivoPase)";
                SqlCommand comando = new SqlCommand(queryPase, conexion_bd);
                comando.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Horaentrada", horaentrada);
                comando.Parameters.AddWithValue("@HoraSalida", horasalida);
                comando.Parameters.AddWithValue("@Clave", clave);
                comando.Parameters.AddWithValue("@IdMotivoPase", idmotivopase);

                comando.ExecuteNonQuery();
                MessageBox.Show("Pase Empleado agregado Exitosamente.", "Éxito");

                // Reinicia el formulario para que no se quede con los datos ya ingresados
                this.Controls.Clear();
                InitializeComponent();


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

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
