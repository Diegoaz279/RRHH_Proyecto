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

        }

        private void aGREGARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Empleado principal = new Agregar_Empleado();
            principal.Show();
        }
    }
}
