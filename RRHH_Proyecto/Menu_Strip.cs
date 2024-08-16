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

            //Para tener la ventana en el area de trabajo
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void aCERToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Creadores creadores = new Creadores();
            creadores.ShowDialog();
        }

        private void Menu_Strip_Load(object sender, EventArgs e)
        {
           
        }

        private void aGREGARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Empleado principal = new Agregar_Empleado();
            principal.Show();
        }
        private void aUSENCIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Ausencia principal = new Agregar_Ausencia();
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



        // En este apartado hacemos que cuando le demos a ese boton en el menustrip lo redireccione a los formularios determinados 
        private void aGREGARDEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Departamento principal = new Agregar_Departamento();
            principal.ShowDialog();
        }

        private void vEREMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_empleado _Empleado = new Consulta_empleado();
            _Empleado.ShowDialog();
        }

        private void vERRETRASOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Retrasos consulta_Retrasos = new Consulta_Retrasos();
            consulta_Retrasos.ShowDialog();
        }

        private void pASEEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pase_Empleado pase_Empleado = new Pase_Empleado();
            pase_Empleado.ShowDialog();
        }

        private void rETRASOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Retraso retraso = new Agregar_Retraso();
            retraso.ShowDialog();
        }

        private void vERAUSENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAusencias verAusencias = new VerAusencias();
            verAusencias.ShowDialog();
        }

        private void hORASEXTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerHorasExtras horasExtras = new VerHorasExtras();
            horasExtras.ShowDialog();
        }

        private void vERHORARIOASIGNADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerHorarioAsignado verHorarioAsignado = new VerHorarioAsignado();
            verHorarioAsignado.ShowDialog();
        }

        private void aSIGNARHORARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Horario agregar_Horario = new Agregar_Horario();
            agregar_Horario.ShowDialog();
        }

        private void aGREGARHORASEXTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_HorasExtras agregar_HorasExtras = new Agregar_HorasExtras();
            agregar_HorasExtras.ShowDialog();
        }

        private void vERDEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_Departamento ver_Departamentos = new Ver_Departamento();
            ver_Departamentos.ShowDialog();
        }

        private void mOTIVODEPASEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ver_MotivoPase ver_MotivoPase = new Ver_MotivoPase();
            ver_MotivoPase.ShowDialog();
        }

        private void vERLOSTIPOSDERETRASOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_TipoRetraso ver_TipoRetraso = new Ver_TipoRetraso();
            ver_TipoRetraso.ShowDialog();
        }

        private void vERAUSENCIADEUNEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_TiposAusencia ver_TIPO = new Ver_TiposAusencia();
            ver_TIPO.ShowDialog();
        }
    }
}
