using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void lbnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmacion conf = new Confirmacion();
            conf.FormClosed += (s, args) => this.Show();
            conf.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadeEstudiantes ListEstud = new ListadeEstudiantes();
            ListEstud.FormClosed += (s, args) => this.Show();
            ListEstud.Show();
           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formAnterior = new Menu();
            formAnterior.Show();
        }

        private void pcCerrarAsistencia_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcMinimizarAsistencia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
