﻿namespace Sga
{
    partial class RegistroEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEstudiantes));
            this.lblRegistroEstudiante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lbnEliminar = new System.Windows.Forms.Button();
            this.lbnConfirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbnEditar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pcMinimizarRegistro = new System.Windows.Forms.PictureBox();
            this.pcCerrarRegistro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroEstudiante
            // 
            this.lblRegistroEstudiante.AutoSize = true;
            this.lblRegistroEstudiante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblRegistroEstudiante.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRegistroEstudiante.Location = new System.Drawing.Point(252, 51);
            this.lblRegistroEstudiante.Name = "lblRegistroEstudiante";
            this.lblRegistroEstudiante.Size = new System.Drawing.Size(286, 32);
            this.lblRegistroEstudiante.TabIndex = 0;
            this.lblRegistroEstudiante.Text = "Registro de Estudiantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres Completo del Estudiante:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCedula.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCedula.Location = new System.Drawing.Point(269, 212);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(255, 20);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Numero de Cedula del Estudiante:";
            // 
            // lbnEliminar
            // 
            this.lbnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbnEliminar.Location = new System.Drawing.Point(194, 326);
            this.lbnEliminar.Name = "lbnEliminar";
            this.lbnEliminar.Size = new System.Drawing.Size(121, 82);
            this.lbnEliminar.TabIndex = 5;
            this.lbnEliminar.Text = "Eliminar Estudiante";
            this.lbnEliminar.UseVisualStyleBackColor = false;
            // 
            // lbnConfirmar
            // 
            this.lbnConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbnConfirmar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbnConfirmar.Location = new System.Drawing.Point(477, 326);
            this.lbnConfirmar.Name = "lbnConfirmar";
            this.lbnConfirmar.Size = new System.Drawing.Size(121, 82);
            this.lbnConfirmar.TabIndex = 6;
            this.lbnConfirmar.Text = "Confirmar Estudiante";
            this.lbnConfirmar.UseVisualStyleBackColor = false;
            this.lbnConfirmar.Click += new System.EventHandler(this.lbnConfirmar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(194, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(194, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(404, 22);
            this.textBox3.TabIndex = 9;
            // 
            // lbnEditar
            // 
            this.lbnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbnEditar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbnEditar.Location = new System.Drawing.Point(335, 326);
            this.lbnEditar.Name = "lbnEditar";
            this.lbnEditar.Size = new System.Drawing.Size(121, 82);
            this.lbnEditar.TabIndex = 10;
            this.lbnEditar.Text = "Editar Estudiante";
            this.lbnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::Sga.Properties.Resources.atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 47);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pcMinimizarRegistro
            // 
            this.pcMinimizarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.pcMinimizarRegistro.ErrorImage = null;
            this.pcMinimizarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("pcMinimizarRegistro.Image")));
            this.pcMinimizarRegistro.InitialImage = null;
            this.pcMinimizarRegistro.Location = new System.Drawing.Point(726, 3);
            this.pcMinimizarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.pcMinimizarRegistro.Name = "pcMinimizarRegistro";
            this.pcMinimizarRegistro.Size = new System.Drawing.Size(36, 32);
            this.pcMinimizarRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMinimizarRegistro.TabIndex = 16;
            this.pcMinimizarRegistro.TabStop = false;
            this.pcMinimizarRegistro.Click += new System.EventHandler(this.pcMinimizarRegistro_Click);
            // 
            // pcCerrarRegistro
            // 
            this.pcCerrarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.pcCerrarRegistro.ErrorImage = null;
            this.pcCerrarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrarRegistro.Image")));
            this.pcCerrarRegistro.InitialImage = null;
            this.pcCerrarRegistro.Location = new System.Drawing.Point(760, 3);
            this.pcCerrarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.pcCerrarRegistro.Name = "pcCerrarRegistro";
            this.pcCerrarRegistro.Size = new System.Drawing.Size(36, 32);
            this.pcCerrarRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCerrarRegistro.TabIndex = 15;
            this.pcCerrarRegistro.TabStop = false;
            this.pcCerrarRegistro.Click += new System.EventHandler(this.pcCerrarRegistro_Click);
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources._0a7386931541a695d5d390fec975cb34;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcMinimizarRegistro);
            this.Controls.Add(this.pcCerrarRegistro);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lbnEditar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbnConfirmar);
            this.Controls.Add(this.lbnEliminar);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistroEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroEstudiantes";
            this.Text = "RegistroEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button lbnEliminar;
        private System.Windows.Forms.Button lbnConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button lbnEditar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pcMinimizarRegistro;
        private System.Windows.Forms.PictureBox pcCerrarRegistro;
    }
}