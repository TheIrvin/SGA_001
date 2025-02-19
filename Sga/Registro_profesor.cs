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
            
        }

        private void bt_crearCuenta_profesor_Click(object sender, EventArgs e)
        {
            C_el_Registro registro_profesor = new C_el_Registro();

            bool resultado = registro_profesor.RegistrarProfesor(
                txtbox_profesor_gmail.Text,      
                txtbox_profesor_contraseña.Text, 
                txtbox_profesor_nombres.Text,   
                txtbox_profesor_apellidos.Text,  
                txtbox_profesor_cédula.Text,     
                txtbox_profesor_teléfono.Text    
            );

            if (resultado)
            {
                MessageBox.Show("Profesor registrado con éxito.");
            }
        }
    }
}
