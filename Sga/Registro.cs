using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sga
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void cbox_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbox_registro_alumno.SelectedItem.ToString() == "Alumno")
            {
                // Mostrar campos de Alumno y ocultar los de Profesor
                lblGrado.Visible = true;
                txtGrado.Visible = true;

                lblMateria.Visible = false;
                txtMateria.Visible = false;
            }
            */

            if (cbox_registro_alumno.SelectedItem.ToString() == "Profesor")
            {
                Registro_profesor form_registroProfesor = new Registro_profesor();
                form_registroProfesor.Show();
                this.Close();
            }
        }
    }
}
