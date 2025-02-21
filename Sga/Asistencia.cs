﻿using System;
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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void lbnRegistro_Click(object sender, EventArgs e)
        {
            Confirmacion Conf = new Confirmacion();
            Conf.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListadeEstudiantes ListEstud = new ListadeEstudiantes();
            ListEstud.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formAnterior = new Menu();
            formAnterior.Show();
        }
    }
}
