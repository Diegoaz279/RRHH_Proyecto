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


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            string tipoRetraso = cmb_TipoRetraso.Text;
            string descripcionTipoRetraso = tipoRetraso == "Otros" ? txt_OtroRetraso.Text : tipoRetraso;

            if (string.IsNullOrWhiteSpace(descripcionTipoRetraso))
            {
                MessageBox.Show("Por favor, seleccione un tipo de retraso.", "Error");
                return;
            }

            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text;

            SqlConnection conexion_bd = null;
            try
            {
                conexion_bd = conexion.GetConnection();
                conexion_bd.Open();

                int idTipoRetraso;

                // Verifica si el tipo de retraso ya existe
                string queryCheck = "SELECT IdTipoRetraso FROM TipoRetraso WHERE TipoDeRetraso = @TipoDeRetraso";
                using (SqlCommand comandoCheck = new SqlCommand(queryCheck, conexion_bd))
                {
                    comandoCheck.Parameters.AddWithValue("@TipoDeRetraso", descripcionTipoRetraso);
                    object result = comandoCheck.ExecuteScalar();

                    if (result == null)
                    {
                        // Si no existe, insertamos el nuevo tipo de retraso
                        string queryInsertTipoRetraso = "INSERT INTO TipoRetraso (TipoDeRetraso) VALUES (@TipoDeRetraso); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand comandoInsertTipoRetraso = new SqlCommand(queryInsertTipoRetraso, conexion_bd))
                        {
                            comandoInsertTipoRetraso.Parameters.AddWithValue("@TipoDeRetraso", descripcionTipoRetraso);
                            idTipoRetraso = Convert.ToInt32(comandoInsertTipoRetraso.ExecuteScalar());
                        }
                    }
                    else
                    {
                        idTipoRetraso = Convert.ToInt32(result);
                    }
                }

                // Inserta el retraso en la tabla Retraso
                string queryInsertRetraso = "INSERT INTO Retraso (ID, IdTipoRetraso, Fecha, Minutos, Observacion) VALUES (@ID, @IdTipoRetraso, @Fecha, @Minutos, @Observacion)";
                using (SqlCommand comandoInsertRetraso = new SqlCommand(queryInsertRetraso, conexion_bd))
                {
                    comandoInsertRetraso.Parameters.AddWithValue("@ID", empleadoID);
                    comandoInsertRetraso.Parameters.AddWithValue("@IdTipoRetraso", idTipoRetraso);
                    comandoInsertRetraso.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                    comandoInsertRetraso.Parameters.AddWithValue("@Minutos", 0); // Ajusta según la lógica de tu aplicación
                    comandoInsertRetraso.Parameters.AddWithValue("@Observacion", txt_OtroRetraso.Text);

                    comandoInsertRetraso.ExecuteNonQuery();
                    MessageBox.Show("Retraso agregado exitosamente.", "Éxito");

                    // Reinicia el formulario para que no se quede con los datos ya ingresados
                    this.Controls.Clear();
                    InitializeComponent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar retraso: {ex.Message}", "Error");
            }
            finally
            {
                if (conexion_bd != null && conexion_bd.State == ConnectionState.Open)
                {
                    conexion_bd.Close();
                }
            }
        }

        private int ObtenerIdTipoRetraso(SqlConnection conexion_bd, string descripcionRetraso)
        {
            string query = "SELECT IdRetraso FROM TipoRetraso WHERE TipoRetraso = @TipoRetraso";
            using (SqlCommand comando = new SqlCommand(query, conexion_bd))
            {
                comando.Parameters.AddWithValue("@TipoRetraso", descripcionRetraso);
                object result = comando.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void LimpiarFormulario()
        {
            cmb_Empleado.SelectedIndex = -1;
            cmb_TipoRetraso.SelectedIndex = -1;
            txt_OtroRetraso.Text = "";
            txt_OtroRetraso.Visible = false;
        }

        private void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Retraso_Load(object sender, EventArgs e)
        {
            label2.Focus();
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_TipoRetraso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_TipoRetraso.SelectedItem.ToString() == "Otros")
            {
                txt_OtroRetraso.Visible = true; // Muestra el TextBox
                txt_OtroRetraso.Focus(); // Opcional: Enfoca el TextBox
            }
            else
            {
                txt_OtroRetraso.Visible = false; // Oculta el TextBox
                txt_OtroRetraso.Text = "";
            }
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