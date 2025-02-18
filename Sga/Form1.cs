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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pcCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text == "admin" && txtContra.Text == "1234")
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;    
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsu_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtUsu_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void txtUsu_MouseLeave(object sender, EventArgs e)
        {
      
        }

        private void txtUsu_Enter(object sender, EventArgs e)
        {
            if (txtUsu.Text == "USUARIO")
            {
                txtUsu.Text = "";
                txtUsu.ForeColor = Color.Blue;
            }
        }

        private void txtUsu_Leave(object sender, EventArgs e)
        {
            if (txtUsu.Text == "")
            {
                txtUsu.Text = "USUARIO";
                txtUsu.ForeColor = Color.DarkBlue;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Blue;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.DarkBlue;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void lbl_Registrarse_Click(object sender, EventArgs e)
        {
            Registro Fo_registro = new Registro();
            Fo_registro.Show();
        }

        private void lbl_Registrarse_MouseEnter(object sender, EventArgs e)
        {
            lbl_Registrarse.Cursor = Cursors.Hand;
        }

        private void lbl_Registrarse_MouseLeave(object sender, EventArgs e)
        {
            lbl_Registrarse.Cursor = Cursors.Default;
        }
    }
}
