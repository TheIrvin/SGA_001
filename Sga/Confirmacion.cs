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
                RegistroEstudiantes RegisEstud = new RegistroEstudiantes();
                RegisEstud.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
