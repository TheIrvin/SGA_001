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

        private void bt_Regresar_Estudiante_Click(object sender, EventArgs e)
        {
            Form1 regresar_estudiante = new Form1();
            regresar_estudiante.Show();
            this.Close();
        }

        private void bt_crearCuenta_Estudiante_Click(object sender, EventArgs e)
        {
            C_el_Registro registro_estudiante = new C_el_Registro();

            bool resultado = registro_estudiante.RegistrarAlumno(
                txtBox_nombres_estudiante.Text,
                txtBox_cédula_estudiante.Text,
                txtBox_nombres_padre.Text,
                txtBox_nombres_madre.Text,
                txt_gmail_padres.Text,
                txtBox_teléfono_padres.Text,
                txt_Contraseña_padres.Text
            );

            if (resultado)
            {
                MessageBox.Show("Estudiante registrado con éxito.");

                txtBox_nombres_estudiante.Text = "";
                txtBox_cédula_estudiante.Text = "";
                txtBox_nombres_padre.Text = "";
                txtBox_nombres_madre.Text = "";
                txt_gmail_padres.Text = "";
                txtBox_teléfono_padres.Text = "";
            }

        }

        private void cbox_registro_alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_registro_alumno.SelectedItem.ToString() == "Profesor")
            {
                Registro_profesor registroProfesor = new Registro_profesor();
                registroProfesor.Show();
                this.Close();
            }
        }

        private void bt_CerrarRegis_alumno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
