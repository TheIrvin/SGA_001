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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.lbnRegistro = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pcMinimizarAsistencia = new System.Windows.Forms.PictureBox();
            this.pcCerrarAsistencia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarAsistencia)).BeginInit();
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
            // pcMinimizarAsistencia
            // 
            this.pcMinimizarAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.pcMinimizarAsistencia.ErrorImage = null;
            this.pcMinimizarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("pcMinimizarAsistencia.Image")));
            this.pcMinimizarAsistencia.InitialImage = null;
            this.pcMinimizarAsistencia.Location = new System.Drawing.Point(720, 12);
            this.pcMinimizarAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.pcMinimizarAsistencia.Name = "pcMinimizarAsistencia";
            this.pcMinimizarAsistencia.Size = new System.Drawing.Size(36, 32);
            this.pcMinimizarAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMinimizarAsistencia.TabIndex = 14;
            this.pcMinimizarAsistencia.TabStop = false;
            this.pcMinimizarAsistencia.Click += new System.EventHandler(this.pcMinimizarAsistencia_Click);
            // 
            // pcCerrarAsistencia
            // 
            this.pcCerrarAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.pcCerrarAsistencia.ErrorImage = null;
            this.pcCerrarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrarAsistencia.Image")));
            this.pcCerrarAsistencia.InitialImage = null;
            this.pcCerrarAsistencia.Location = new System.Drawing.Point(754, 12);
            this.pcCerrarAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.pcCerrarAsistencia.Name = "pcCerrarAsistencia";
            this.pcCerrarAsistencia.Size = new System.Drawing.Size(36, 32);
            this.pcCerrarAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCerrarAsistencia.TabIndex = 13;
            this.pcCerrarAsistencia.TabStop = false;
            this.pcCerrarAsistencia.Click += new System.EventHandler(this.pcCerrarAsistencia_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.asistencias;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcMinimizarAsistencia);
            this.Controls.Add(this.pcCerrarAsistencia);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lbnRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbnRegistro;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pcMinimizarAsistencia;
        private System.Windows.Forms.PictureBox pcCerrarAsistencia;
    }
}