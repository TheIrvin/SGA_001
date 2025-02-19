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
    public partial class ListadeEstudiantes : Form
    {
        public ListadeEstudiantes()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Nombre y Apellido", "Nombre  y Apellido");
            dataGridView1.Columns.Add("Cedula", "Cédula");
            dataGridView1.Columns.Add("Estado", "Estado");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
