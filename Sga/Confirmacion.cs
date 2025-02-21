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
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Blue;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                    txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkBlue;
                txtContraseña.UseSystemPasswordChar = false;
            
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "1234")
            {
                this.Hide();
                RegistroEstudiantes regis = new RegistroEstudiantes();
                regis.FormClosed += (s, args) => this.Show();
                regis.Show();
                
            }
            else
            {
                MessageBox.Show("Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencia formAnterior = new Asistencia();
            formAnterior.Show();
        }

        private void pcCerrarConfirmacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcMinimizarConfirmacion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
