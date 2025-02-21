using System;
using System.Collections;
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
    public partial class Menu : Form
    {
        Asistencia asist;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            
        }

        private void boxAsistencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencia formLista = new Asistencia();
            formLista.FormClosed += (s, args) => this.Show();
            formLista.Show();
        }

        private void pcCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
