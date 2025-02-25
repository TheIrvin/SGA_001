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


                string tipoUsuario = el_Login.ObtenerTipoUsuario(gmail);

                if (tipoUsuario == "Alumno")
                {
                    Menu Menu_Alumno = new Menu();
                    Menu_Alumno.Show();
                    this.Hide();
                }
                else if (tipoUsuario == "Profesor")
                {
                    Menu_Profesor el_menu_profesor = new Menu_Profesor();
                    el_menu_profesor.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsu_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtUsu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsu_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtUsu_Enter(object sender, EventArgs e)
        {
            if (txtBox_Usuario_login.Text == "USUARIO")
            {
                txtBox_Usuario_login.Text = "";
                txtBox_Usuario_login.ForeColor = Color.Blue;
            }
        }

        private void txtUsu_Leave(object sender, EventArgs e)
        {
            if (txtBox_Usuario_login.Text == "")
            {
                txtBox_Usuario_login.Text = "USUARIO";
                txtBox_Usuario_login.ForeColor = Color.DarkBlue;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtBox_Contraseña_login.Text == "CONTRASEÑA")
            {
                txtBox_Contraseña_login.Text = "";
                txtBox_Contraseña_login.ForeColor = Color.Blue;
                txtBox_Contraseña_login.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtBox_Contraseña_login.Text == "")
            {
                txtBox_Contraseña_login.Text = "CONTRASEÑA";
                txtBox_Contraseña_login.ForeColor = Color.DarkBlue;
                txtBox_Contraseña_login.UseSystemPasswordChar = false;
            }
        }

        private void lbl_Registrarse_Click(object sender, EventArgs e)
        {
            Form1 el_menu = new Form1();
            this.Hide();
            Registro Fo_registro = new Registro();
            Fo_registro.Show();

        }

        private void lbl_Registrarse_MouseEnter(object sender, EventArgs e)
        {
            lbl_Registrarse.Cursor = Cursors.Hand;
        }

        private void lbl_Registrarse_MouseLeave(object sender, EventArgs e)
        {
            lbl_Registrarse.Cursor = Cursors.Default;
        }

        
    }
}
