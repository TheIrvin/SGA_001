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
    public partial class Registro_profesor : Form
    {
        public Registro_profesor()
        {
            InitializeComponent();
        }

        private void cbox_tipoUsuario_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_tipoUsuario_profesor.SelectedItem.ToString() == "Alumno")
            {
                Registro registroEstudiante = new Registro();
                registroEstudiante.Show();
                this.Close();
            }
        }

        private void panel_sga_Paint(object sender, PaintEventArgs e)
        {
            panel_sga.BackColor = Color.FromArgb(30, 60, 114);
            
        }
    }
}
