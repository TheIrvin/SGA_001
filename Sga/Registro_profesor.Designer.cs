namespace Sga
{
    partial class Registro_profesor
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
            this.bt_crearCuenta_profesor = new System.Windows.Forms.Button();
            this.cbox_tipoUsuario_profesor = new System.Windows.Forms.ComboBox();
            this.lbl_tipoUsuario_profesor = new System.Windows.Forms.Label();
            this.txtbox_profesor_nombres = new System.Windows.Forms.TextBox();
            this.lbl_profesor_nombre = new System.Windows.Forms.Label();
            this.lbl_profesor_cédula = new System.Windows.Forms.Label();
            this.lbl_profesor_gmail = new System.Windows.Forms.Label();
            this.txtbox_profesor_teléfono = new System.Windows.Forms.TextBox();
            this.txtbox_profesor_cédula = new System.Windows.Forms.TextBox();
            this.txtbox_profesor_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_profesor_teléfono = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_profesor_apellidos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbox_profesor_gmail = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_sga = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_profesor_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_profesor_contraseña = new System.Windows.Forms.Label();
            this.panel_sga.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_crearCuenta_profesor
            // 
            this.bt_crearCuenta_profesor.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crearCuenta_profesor.Location = new System.Drawing.Point(49, 380);
            this.bt_crearCuenta_profesor.Name = "bt_crearCuenta_profesor";
            this.bt_crearCuenta_profesor.Size = new System.Drawing.Size(110, 36);
            this.bt_crearCuenta_profesor.TabIndex = 77;
            this.bt_crearCuenta_profesor.Text = "Crear cuenta";
            this.bt_crearCuenta_profesor.UseVisualStyleBackColor = true;
            this.bt_crearCuenta_profesor.Click += new System.EventHandler(this.bt_crearCuenta_profesor_Click);
            // 
            // cbox_tipoUsuario_profesor
            // 
            this.cbox_tipoUsuario_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipoUsuario_profesor.FormattingEnabled = true;
            this.cbox_tipoUsuario_profesor.Items.AddRange(new object[] {
            "Alumno"});
            this.cbox_tipoUsuario_profesor.Location = new System.Drawing.Point(290, 69);
            this.cbox_tipoUsuario_profesor.Name = "cbox_tipoUsuario_profesor";
            this.cbox_tipoUsuario_profesor.Size = new System.Drawing.Size(103, 21);
            this.cbox_tipoUsuario_profesor.TabIndex = 76;
            this.cbox_tipoUsuario_profesor.Tag = "";
            this.cbox_tipoUsuario_profesor.SelectedIndexChanged += new System.EventHandler(this.cbox_tipoUsuario_profesor_SelectedIndexChanged);
            // 
            // lbl_tipoUsuario_profesor
            // 
            this.lbl_tipoUsuario_profesor.AutoSize = true;
            this.lbl_tipoUsuario_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoUsuario_profesor.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoUsuario_profesor.Location = new System.Drawing.Point(49, 74);
            this.lbl_tipoUsuario_profesor.Name = "lbl_tipoUsuario_profesor";
            this.lbl_tipoUsuario_profesor.Size = new System.Drawing.Size(119, 16);
            this.lbl_tipoUsuario_profesor.TabIndex = 75;
            this.lbl_tipoUsuario_profesor.Text = "Tipo de Usuario";
            // 
            // txtbox_profesor_nombres
            // 
            this.txtbox_profesor_nombres.Location = new System.Drawing.Point(290, 123);
            this.txtbox_profesor_nombres.Name = "txtbox_profesor_nombres";
            this.txtbox_profesor_nombres.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_nombres.TabIndex = 73;
            // 
            // lbl_profesor_nombre
            // 
            this.lbl_profesor_nombre.AutoSize = true;
            this.lbl_profesor_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_nombre.Location = new System.Drawing.Point(53, 122);
            this.lbl_profesor_nombre.Name = "lbl_profesor_nombre";
            this.lbl_profesor_nombre.Size = new System.Drawing.Size(77, 18);
            this.lbl_profesor_nombre.TabIndex = 72;
            this.lbl_profesor_nombre.Text = "Nombres";
            // 
            // lbl_profesor_cédula
            // 
            this.lbl_profesor_cédula.AutoSize = true;
            this.lbl_profesor_cédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_cédula.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_cédula.Location = new System.Drawing.Point(53, 213);
            this.lbl_profesor_cédula.Name = "lbl_profesor_cédula";
            this.lbl_profesor_cédula.Size = new System.Drawing.Size(60, 18);
            this.lbl_profesor_cédula.TabIndex = 71;
            this.lbl_profesor_cédula.Text = "Cédula";
            // 
            // lbl_profesor_gmail
            // 
            this.lbl_profesor_gmail.AutoSize = true;
            this.lbl_profesor_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_gmail.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_gmail.Location = new System.Drawing.Point(53, 303);
            this.lbl_profesor_gmail.Name = "lbl_profesor_gmail";
            this.lbl_profesor_gmail.Size = new System.Drawing.Size(52, 18);
            this.lbl_profesor_gmail.TabIndex = 70;
            this.lbl_profesor_gmail.Text = "Gmail";
            // 
            // txtbox_profesor_teléfono
            // 
            this.txtbox_profesor_teléfono.Location = new System.Drawing.Point(290, 256);
            this.txtbox_profesor_teléfono.Name = "txtbox_profesor_teléfono";
            this.txtbox_profesor_teléfono.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_teléfono.TabIndex = 69;
            // 
            // txtbox_profesor_cédula
            // 
            this.txtbox_profesor_cédula.Location = new System.Drawing.Point(290, 211);
            this.txtbox_profesor_cédula.Name = "txtbox_profesor_cédula";
            this.txtbox_profesor_cédula.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_cédula.TabIndex = 68;
            // 
            // txtbox_profesor_apellidos
            // 
            this.txtbox_profesor_apellidos.Location = new System.Drawing.Point(290, 168);
            this.txtbox_profesor_apellidos.Name = "txtbox_profesor_apellidos";
            this.txtbox_profesor_apellidos.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_apellidos.TabIndex = 67;
            // 
            // lbl_profesor_teléfono
            // 
            this.lbl_profesor_teléfono.AutoSize = true;
            this.lbl_profesor_teléfono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_teléfono.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_teléfono.Location = new System.Drawing.Point(49, 258);
            this.lbl_profesor_teléfono.Name = "lbl_profesor_teléfono";
            this.lbl_profesor_teléfono.Size = new System.Drawing.Size(74, 18);
            this.lbl_profesor_teléfono.TabIndex = 66;
            this.lbl_profesor_teléfono.Text = "Teléfono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(46, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 65;
            // 
            // lbl_profesor_apellidos
            // 
            this.lbl_profesor_apellidos.AutoSize = true;
            this.lbl_profesor_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_apellidos.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_apellidos.Location = new System.Drawing.Point(53, 167);
            this.lbl_profesor_apellidos.Name = "lbl_profesor_apellidos";
            this.lbl_profesor_apellidos.Size = new System.Drawing.Size(76, 18);
            this.lbl_profesor_apellidos.TabIndex = 64;
            this.lbl_profesor_apellidos.Text = "Apellidos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(49, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 63;
            // 
            // txtbox_profesor_gmail
            // 
            this.txtbox_profesor_gmail.Location = new System.Drawing.Point(290, 304);
            this.txtbox_profesor_gmail.Name = "txtbox_profesor_gmail";
            this.txtbox_profesor_gmail.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_gmail.TabIndex = 78;
            // 
            // panel_sga
            // 
            this.panel_sga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.panel_sga.Controls.Add(this.label1);
            this.panel_sga.Location = new System.Drawing.Point(0, 0);
            this.panel_sga.Name = "panel_sga";
            this.panel_sga.Size = new System.Drawing.Size(606, 65);
            this.panel_sga.TabIndex = 79;
            this.panel_sga.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sga_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGA";
            // 
            // txtbox_profesor_contraseña
            // 
            this.txtbox_profesor_contraseña.Location = new System.Drawing.Point(290, 347);
            this.txtbox_profesor_contraseña.Name = "txtbox_profesor_contraseña";
            this.txtbox_profesor_contraseña.Size = new System.Drawing.Size(175, 20);
            this.txtbox_profesor_contraseña.TabIndex = 81;
            // 
            // lbl_profesor_contraseña
            // 
            this.lbl_profesor_contraseña.AutoSize = true;
            this.lbl_profesor_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor_contraseña.Location = new System.Drawing.Point(53, 346);
            this.lbl_profesor_contraseña.Name = "lbl_profesor_contraseña";
            this.lbl_profesor_contraseña.Size = new System.Drawing.Size(95, 18);
            this.lbl_profesor_contraseña.TabIndex = 80;
            this.lbl_profesor_contraseña.Text = "Contraseña";
            // 
            // Registro_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(603, 428);
            this.Controls.Add(this.txtbox_profesor_contraseña);
            this.Controls.Add(this.lbl_profesor_contraseña);
            this.Controls.Add(this.panel_sga);
            this.Controls.Add(this.txtbox_profesor_gmail);
            this.Controls.Add(this.bt_crearCuenta_profesor);
            this.Controls.Add(this.cbox_tipoUsuario_profesor);
            this.Controls.Add(this.lbl_tipoUsuario_profesor);
            this.Controls.Add(this.txtbox_profesor_nombres);
            this.Controls.Add(this.lbl_profesor_nombre);
            this.Controls.Add(this.lbl_profesor_cédula);
            this.Controls.Add(this.lbl_profesor_gmail);
            this.Controls.Add(this.txtbox_profesor_teléfono);
            this.Controls.Add(this.txtbox_profesor_cédula);
            this.Controls.Add(this.txtbox_profesor_apellidos);
            this.Controls.Add(this.lbl_profesor_teléfono);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_profesor_apellidos);
            this.Controls.Add(this.label16);
            this.Name = "Registro_profesor";
            this.Text = "Registro_profesor";
            this.panel_sga.ResumeLayout(false);
            this.panel_sga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_crearCuenta_profesor;
        private System.Windows.Forms.ComboBox cbox_tipoUsuario_profesor;
        private System.Windows.Forms.Label lbl_tipoUsuario_profesor;
        private System.Windows.Forms.TextBox txtbox_profesor_nombres;
        private System.Windows.Forms.Label lbl_profesor_nombre;
        private System.Windows.Forms.Label lbl_profesor_cédula;
        private System.Windows.Forms.Label lbl_profesor_gmail;
        private System.Windows.Forms.TextBox txtbox_profesor_teléfono;
        private System.Windows.Forms.TextBox txtbox_profesor_cédula;
        private System.Windows.Forms.TextBox txtbox_profesor_apellidos;
        private System.Windows.Forms.Label lbl_profesor_teléfono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_profesor_apellidos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbox_profesor_gmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_sga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_profesor_contraseña;
        private System.Windows.Forms.Label lbl_profesor_contraseña;
    }
}