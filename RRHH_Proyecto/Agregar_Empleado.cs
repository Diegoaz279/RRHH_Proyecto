using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH_Proyecto
{
    public partial class Agregar_Empleado : Form
    {
        public Agregar_Empleado()
        {
            InitializeComponent();
        }

        //APARTADO PARA QUE APAREZCAN Y DESAPAREZCAN LAS LETRAS DE INFO DE LOS TEXT BOX
        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "NOMBRE")
            {
                txt_Nombre.Text = "";
                txt_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                txt_Nombre.Text = "NOMBRE";
                txt_Nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_Apellido_Enter(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "APELLIDO")
            {
                txt_Apellido.Text = "";
                txt_Apellido.ForeColor = Color.DimGray;
            }
        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "")
            {
                txt_Apellido.Text = "APELLIDO";
                txt_Apellido.ForeColor = Color.DimGray;
            }
        }

        private void txt_Cedula_Enter(object sender, EventArgs e)
        {
            if (txt_Cedula.Text == "CEDULA")
            {
                txt_Cedula.Text = "";
                txt_Cedula.ForeColor = Color.DimGray;
            }
        }

        private void txt_Cedula_Leave(object sender, EventArgs e)
        {
            if (txt_Cedula.Text == "")
            {
                txt_Cedula.Text = "CEDULA";
                txt_Cedula.ForeColor = Color.DimGray;
            }
        }

        private void txt_Nacimiento_Enter(object sender, EventArgs e)
        {
            if (txt_Nacimiento.Text == "LUGAR DE NACIMIENTO")
            {
                txt_Nacimiento.Text = "";
                txt_Nacimiento.ForeColor = Color.DimGray;
            }
        }

        private void txt_Nacimiento_Leave(object sender, EventArgs e)
        {
            if (txt_Nacimiento.Text == "")
            {
                txt_Nacimiento.Text = "LUGAR DE NACIMIENTO";
                txt_Nacimiento.ForeColor = Color.DimGray;
            }
        }

        private void txt_Cargo_Enter(object sender, EventArgs e)
        {
            if (txt_Cargo.Text == "CARGO")
            {
                txt_Cargo.Text = "";
                txt_Cargo.ForeColor = Color.DimGray;
            }
        }

        private void txt_Cargo_Leave(object sender, EventArgs e)
        {
            if (txt_Cargo.Text == "")
            {
                txt_Cargo.Text = "CARGO";
                txt_Cargo.ForeColor = Color.DimGray;
            }

        }

        private void txt_Telefono_Enter(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "NUMERO DE TELEFONO")
            {
                txt_Telefono.Text = "";
                txt_Telefono.ForeColor = Color.DimGray;
            }
        }

        private void txt_Telefono_Leave(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "")
            {
                txt_Telefono.Text = "NUMERO DE TELEFONO";
                txt_Telefono.ForeColor = Color.DimGray;
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "CORREO ELECTRONICO")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "CORREO ELECTRONICO";
                txt_Correo.ForeColor = Color.DimGray;
            }
        }

       
    }
}
