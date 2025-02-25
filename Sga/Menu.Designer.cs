namespace Sga
{
    partial class Menu
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurarM = new System.Windows.Forms.Button();
            this.btnMaximizarmenu = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Sga.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.Location = new System.Drawing.Point(645, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.YellowGreen;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnRestaurarM);
            this.panelMenu.Controls.Add(this.btnMaximizarmenu);
            this.panelMenu.Controls.Add(this.btnMinimizar);
            this.panelMenu.Controls.Add(this.btnCerrar);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(676, 65);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "SGA";
            // 
            // btnRestaurarM
            // 
            this.btnRestaurarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarM.FlatAppearance.BorderSize = 0;
            this.btnRestaurarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestaurarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestaurarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarM.Image = global::Sga.Properties.Resources.Icono_Restaurar;
            this.btnRestaurarM.Location = new System.Drawing.Point(609, 0);
            this.btnRestaurarM.Name = "btnRestaurarM";
            this.btnRestaurarM.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurarM.TabIndex = 7;
            this.btnRestaurarM.UseVisualStyleBackColor = true;
            this.btnRestaurarM.Visible = false;
            this.btnRestaurarM.Click += new System.EventHandler(this.btnRestaurarM_Click);
            // 
            // btnMaximizarmenu
            // 
            this.btnMaximizarmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizarmenu.FlatAppearance.BorderSize = 0;
            this.btnMaximizarmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMaximizarmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMaximizarmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarmenu.Image = global::Sga.Properties.Resources.Icono_Maximizar;
            this.btnMaximizarmenu.Location = new System.Drawing.Point(609, 0);
            this.btnMaximizarmenu.Name = "btnMaximizarmenu";
            this.btnMaximizarmenu.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizarmenu.TabIndex = 6;
            this.btnMaximizarmenu.UseVisualStyleBackColor = true;
            this.btnMaximizarmenu.Click += new System.EventHandler(this.btnMaximizarmenu_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::Sga.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(573, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareas.BackgroundImage = global::Sga.Properties.Resources.Tarea_pic;
            this.btnTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Location = new System.Drawing.Point(12, 71);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(117, 99);
            this.btnTareas.TabIndex = 6;
            this.btnTareas.UseVisualStyleBackColor = false;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.BackgroundImage = global::Sga.Properties.Resources.Asistencia_pic;
            this.btnAsistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.Location = new System.Drawing.Point(12, 176);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(117, 113);
            this.btnAsistencias.TabIndex = 7;
            this.btnAsistencias.UseVisualStyleBackColor = true;
            this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackgroundImage = global::Sga.Properties.Resources.Horarios_pic;
            this.btnHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Location = new System.Drawing.Point(11, 295);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(118, 99);
            this.btnHorarios.TabIndex = 8;
            this.btnHorarios.UseVisualStyleBackColor = true;
            // 
            // btnMensajes
            // 
            this.btnMensajes.BackgroundImage = global::Sga.Properties.Resources.Mensajes_pic;
            this.btnMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMensajes.FlatAppearance.BorderSize = 0;
            this.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajes.Location = new System.Drawing.Point(11, 400);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(118, 81);
            this.btnMensajes.TabIndex = 9;
            this.btnMensajes.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.Imagen_menú_profesor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 493);
            this.Controls.Add(this.btnMensajes);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnAsistencias);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.Menu_BackgroundImageLayoutChanged);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMaximizarmenu;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurarM;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnMensajes;
        private System.Windows.Forms.Label label1;
    }
}