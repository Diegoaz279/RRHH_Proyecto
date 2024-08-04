using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace RRHH_Proyecto
{
    

    public partial class Form1 : Form
    {
        private Conexion conexion = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select usuario,contrasena from usuarios where usuario = @usuario and contrasena = @contraseña";
                string usuario = txt_Usuario.Text;
                string contraseña = txt_Contraseña.Text;

                SqlConnection conexion_bd = conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(query, conexion_bd);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Exitoso", "Sistema");
                    Menu_Strip principal = new Menu_Strip();
                    principal.Show();

                    this.Hide();
                    conexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Sistema");
                    conexion.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos" + ex);
            }
        }

    }
}
