namespace Sga
{
    partial class Asistencia
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
            this.lbnRegistro = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnRegistro
            // 
            this.lbnRegistro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbnRegistro.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbnRegistro.Location = new System.Drawing.Point(201, 178);
            this.lbnRegistro.Name = "lbnRegistro";
            this.lbnRegistro.Size = new System.Drawing.Size(170, 112);
            this.lbnRegistro.TabIndex = 0;
            this.lbnRegistro.Text = "Registro de estudiantes";
            this.lbnRegistro.UseVisualStyleBackColor = false;
            this.lbnRegistro.Click += new System.EventHandler(this.lbnRegistro_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLista.Location = new System.Drawing.Point(443, 178);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(170, 112);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(195, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro y Listado de Estudiantes";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::Sga.Properties.Resources.atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 47);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.asistencias;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lbnRegistro);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbnRegistro;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
    }
}