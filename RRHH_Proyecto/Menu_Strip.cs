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
    public partial class Menu_Strip : Form
    {
        
        public Menu_Strip()
        {
            InitializeComponent();
        }

        private void aCERToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Strip_Load(object sender, EventArgs e)
        {
            //hola
        }

        private void aGREGARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Empleado principal = new Agregar_Empleado();
            principal.Show();
        }

        private void eNTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }
    }
}
