﻿using System;
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
    public partial class Agregar_Horario : Form
    {
        Conexion0 conexion = new Conexion0();
        public Agregar_Horario()
        {
            InitializeComponent();

        }
        private void Agregar_Horario_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            cmb_Empleado.SelectedIndex = -1;
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


            //Captura el error de que si no se selecciona un empleado, osea que no se dejen campos vacios
            if (cmb_Empleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error");
                return;
            }

            //Aqui se obtiene el ID y nombre del empleado
            int empleadoID = (int)cmb_Empleado.SelectedValue;
            string empleadoNombre = cmb_Empleado.Text; //Esto obtiene el nombre completo mostrado en el ComboBox
            string horasalida = mb_HoraSalida.Text;
            string horaentrada = mb_HoraEntrada.Text;



            //Aqui se instancia la clase de conexion y la almacenamos en una variable
            Conexion0 conexion = new Conexion0();
            SqlConnection conexion_bd = null;

            try
            {
                conexion_bd = conexion.GetConnection();

                // Insertar en la tabla Horario, incluyendo el nombre del empleado, id del empleado etc
                string query = "INSERT INTO Horario (Nombre, IdNombre, HEntrada, HSalida) VALUES (@Nombree, @IdNOMBRE, @HEntrada, @HSalida)";
                SqlCommand comando = new SqlCommand(query, conexion_bd);
                comando.Parameters.AddWithValue("@Nombree", empleadoNombre);
                comando.Parameters.AddWithValue("@IdNOMBRE", empleadoID);
                comando.Parameters.AddWithValue("@HEntrada", horaentrada);
                comando.Parameters.AddWithValue("@HSalida", horasalida);

                comando.ExecuteNonQuery();
                MessageBox.Show("Horario agregado exitosamente.", "Éxito");

                // cierra el formulario
                this.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar Horario: {ex.Message}", "Error");
            }

            finally // Finalmente cierre de la conexion 
            {
                conexion.CloseConnection();
            }



        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
