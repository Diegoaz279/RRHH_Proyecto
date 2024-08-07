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
        //Se llama la clase de la conexion 
        private Conexion conexion = new Conexion();

        public Form1()
        {
            InitializeComponent();

            //Esto es para cuando se maximize se quede en el area de trabajo
            this.MaximizedBounds =Screen.FromHandle(this.Handle).WorkingArea;   
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            //hola

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
                    //MessageBox.Show($"Bienvenido  {usuario}", "Sistema");
                    Menu_Strip principal = new Menu_Strip();
                    principal.Show();

                    this.Hide();
                    conexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos", "Sistema");
                    conexion.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos" + ex);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "CONTRASEÑA")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "CONTRASEÑA";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        // Comfiguracion de los botones Cerra, Maximizar y Minimizar
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;

        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }
    }
}
