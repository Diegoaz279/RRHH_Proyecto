using RRHH_Proyecto;
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
        Conexion0 conexion = new Conexion0();

        public Form1()
        {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Asociar el evento KeyDown a los TextBox
            txt_Usuario.KeyDown += new KeyEventHandler(txt_KeyDown);
            txt_Contraseña.KeyDown += new KeyEventHandler(txt_KeyDown);
        }
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Para evitar el sonido al salir el mensaje
                btn_Ingresar_Click(sender, e);
            }
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Conexion0 conexion = new Conexion0();

            try
            {
                string query = "SELECT usuario, contrasena FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
                string usuario = txt_Usuario.Text;
                string contrasena = txt_Contraseña.Text;

                using (SqlCommand comando = new SqlCommand(query, conexion.GetConnection()))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);

                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Usuario y contraseña correctos, abrir el menú principal
                        Menu_Strip principal = new Menu_Strip();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Usuario o contraseña incorrectos
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CloseConnection();
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

  

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//NO TERMINADO
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el comportamiento predeterminado
            }
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



