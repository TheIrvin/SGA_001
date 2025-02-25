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
            C_verificar_login el_Login = new C_verificar_login();

            string gmail = txtBox_Usuario_login.Text;
            string contraseña = txtBox_Contraseña_login.Text;
            bool resultado = el_Login.VerificarLogin(gmail, contraseña);

            if (resultado)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtBox_Usuario_login_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtBox_Usuario_login_Enter(object sender, EventArgs e)
        {
            if (txtBox_Usuario_login.Text == "USUARIO")
            {
                txtBox_Usuario_login.Text = "";
                txtBox_Usuario_login.ForeColor = Color.Blue;
            }
        }
    }
}
              
