namespace Sga
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbllUsu = new System.Windows.Forms.Label();
            this.lbllContra = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.pcCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPerdida = new System.Windows.Forms.LinkLabel();
            this.lbl_Registrarse = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(186, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SGA";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lbllUsu
            // 
            this.lbllUsu.AutoSize = true;
            this.lbllUsu.BackColor = System.Drawing.Color.Transparent;
            this.lbllUsu.ForeColor = System.Drawing.Color.Blue;
            this.lbllUsu.Location = new System.Drawing.Point(70, 147);
            this.lbllUsu.Name = "lbllUsu";
            this.lbllUsu.Size = new System.Drawing.Size(313, 13);
            this.lbllUsu.TabIndex = 1;
            this.lbllUsu.Text = "___________________________________________________";
            // 
            // lbllContra
            // 
            this.lbllContra.AutoSize = true;
            this.lbllContra.BackColor = System.Drawing.Color.Transparent;
            this.lbllContra.ForeColor = System.Drawing.Color.Blue;
            this.lbllContra.Location = new System.Drawing.Point(70, 201);
            this.lbllContra.Name = "lbllContra";
            this.lbllContra.Size = new System.Drawing.Size(313, 13);
            this.lbllContra.TabIndex = 2;
            this.lbllContra.Text = "___________________________________________________";
            // 
            // txtUsu
            // 
            this.txtUsu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUsu.Location = new System.Drawing.Point(71, 140);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(310, 19);
            this.txtUsu.TabIndex = 2;
            this.txtUsu.Text = "USUARIO";
            this.txtUsu.TextChanged += new System.EventHandler(this.txtUsu_TextChanged);
            this.txtUsu.Enter += new System.EventHandler(this.txtUsu_Enter);
            this.txtUsu.Leave += new System.EventHandler(this.txtUsu_Leave);
            this.txtUsu.MouseEnter += new System.EventHandler(this.txtUsu_MouseEnter);
            this.txtUsu.MouseLeave += new System.EventHandler(this.txtUsu_MouseLeave);
            this.txtUsu.MouseHover += new System.EventHandler(this.txtUsu_MouseHover);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtContra.Location = new System.Drawing.Point(73, 192);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(309, 19);
            this.txtContra.TabIndex = 3;
            this.txtContra.Text = "CONTRASEÑA";
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(73, 239);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(308, 36);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // pcCerrar
            // 
            this.pcCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcCerrar.ErrorImage = null;
            this.pcCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrar.Image")));
            this.pcCerrar.InitialImage = null;
            this.pcCerrar.Location = new System.Drawing.Point(418, -1);
            this.pcCerrar.Name = "pcCerrar";
            this.pcCerrar.Size = new System.Drawing.Size(27, 26);
            this.pcCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCerrar.TabIndex = 6;
            this.pcCerrar.TabStop = false;
            this.pcCerrar.Click += new System.EventHandler(this.pcCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(390, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPerdida
            // 
            this.lblPerdida.AutoSize = true;
            this.lblPerdida.Location = new System.Drawing.Point(208, 278);
            this.lblPerdida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerdida.Name = "lblPerdida";
            this.lblPerdida.Size = new System.Drawing.Size(149, 13);
            this.lblPerdida.TabIndex = 1;
            this.lblPerdida.TabStop = true;
            this.lblPerdida.Text = "¿Has olvidado tu contraseña?";
            // 
            // lbl_Registrarse
            // 
            this.lbl_Registrarse.AutoSize = true;
            this.lbl_Registrarse.Location = new System.Drawing.Point(124, 278);
            this.lbl_Registrarse.Name = "lbl_Registrarse";
            this.lbl_Registrarse.Size = new System.Drawing.Size(60, 13);
            this.lbl_Registrarse.TabIndex = 8;
            this.lbl_Registrarse.Text = "Registrarse";
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.Location = new System.Drawing.Point(190, 278);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(13, 13);
            this.lbl_o.TabIndex = 9;
            this.lbl_o.Text = "o";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.lbl_Registrarse);
            this.Controls.Add(this.lblPerdida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcCerrar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.lbllContra);
            this.Controls.Add(this.lbllUsu);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbllUsu;
        private System.Windows.Forms.Label lbllContra;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.PictureBox pcCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblPerdida;
        private System.Windows.Forms.Label lbl_Registrarse;
        private System.Windows.Forms.Label lbl_o;
    }
}

