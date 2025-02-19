using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Sga
{
    public partial class Registro_profesor : Form
    {
        public Registro_profesor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cbox_tipoUsuario_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_tipoUsuario_profesor.SelectedItem.ToString() == "Alumno")
            {
                Registro registroEstudiante = new Registro();
                registroEstudiante.Show();
                this.Close();
            }
        }

        private void btnCerrarRegisProfe_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxiRegisProfe_Click(object sender, EventArgs e)
        {
            btnMaxiRegisProfe.Visible = false;
            btnRestauRegisProfe.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMiniRegisProfe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestauRegisProfe_Click(object sender, EventArgs e)
        {
            btnRestauRegisProfe.Visible = false;
            btnMaxiRegisProfe.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void panel_sga_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
