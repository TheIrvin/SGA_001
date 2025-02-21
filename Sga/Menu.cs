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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir el formulario "Lista"
            Asistencia formLista = new Asistencia();

            // Evento para volver a mostrar "Menu" cuando se cierre "Lista"
            formLista.FormClosed += (s, args) => this.Show();

            formLista.Show();
        }
    }
}
