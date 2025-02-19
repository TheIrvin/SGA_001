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

            if (cbox_registro_alumno.SelectedItem.ToString() == "Profesor")
            {
                Registro_profesor form_registroProfesor = new Registro_profesor();
                form_registroProfesor.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_CrearCuenta_alumno_Click(object sender, EventArgs e)
        {
            C_el_Registro registro_alumno = new C_el_Registro();

            bool resultado = registro_alumno.RegistrarAlumno(


                txtBox_nombres_estudiante.Text,
                txtBox_cédula_estudiante.Text,
                txtBox_nombres_padre.Text,
                txtBox_nombres_madre.Text,
                txtBox_teléfono_padres.Text,
                txt_gmail_padres.Text,
                txtBox_contraseña_alumno.Text
            );

            if (resultado)
            {
                MessageBox.Show("Alumno registrado con éxito.");
            }
        }
    }
}
