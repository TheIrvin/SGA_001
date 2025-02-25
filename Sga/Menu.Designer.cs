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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxAsistencia = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pcCerrarMenu = new System.Windows.Forms.PictureBox();
            this.pcMinimizarMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sga.Properties.Resources.Tarea_pic;
            this.pictureBox1.Location = new System.Drawing.Point(127, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // boxAsistencia
            // 
            this.boxAsistencia.Image = global::Sga.Properties.Resources.Asistencia_pic;
            this.boxAsistencia.Location = new System.Drawing.Point(561, 112);
            this.boxAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.boxAsistencia.Name = "boxAsistencia";
            this.boxAsistencia.Size = new System.Drawing.Size(185, 196);
            this.boxAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxAsistencia.TabIndex = 1;
            this.boxAsistencia.TabStop = false;
            this.boxAsistencia.Click += new System.EventHandler(this.boxAsistencia_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sga.Properties.Resources.Horarios_pic;
            this.pictureBox3.Location = new System.Drawing.Point(127, 420);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sga.Properties.Resources.Mensajes_pic;
            this.pictureBox4.Location = new System.Drawing.Point(561, 420);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(191, 162);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;

            // 
            // pcCerrarMenu
            // 
            this.pcCerrarMenu.BackColor = System.Drawing.Color.Transparent;
            this.pcCerrarMenu.ErrorImage = null;
            this.pcCerrarMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrarMenu.Image")));
            this.pcCerrarMenu.InitialImage = null;
            this.pcCerrarMenu.Location = new System.Drawing.Point(871, 4);
            this.pcCerrarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pcCerrarMenu.Name = "pcCerrarMenu";
            this.pcCerrarMenu.Size = new System.Drawing.Size(36, 32);
            this.pcCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCerrarMenu.TabIndex = 7;
            this.pcCerrarMenu.TabStop = false;
            this.pcCerrarMenu.Click += new System.EventHandler(this.pcCerrarMenu_Click);
            // 
            // pcMinimizarMenu
            // 
            this.pcMinimizarMenu.BackColor = System.Drawing.Color.Transparent;
            this.pcMinimizarMenu.ErrorImage = null;
            this.pcMinimizarMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcMinimizarMenu.Image")));
            this.pcMinimizarMenu.InitialImage = null;
            this.pcMinimizarMenu.Location = new System.Drawing.Point(839, 4);
            this.pcMinimizarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pcMinimizarMenu.Name = "pcMinimizarMenu";
            this.pcMinimizarMenu.Size = new System.Drawing.Size(36, 32);
            this.pcMinimizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMinimizarMenu.TabIndex = 8;
            this.pcMinimizarMenu.TabStop = false;
            this.pcMinimizarMenu.Click += new System.EventHandler(this.pcMinimizarMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.Imagen_menú_profesor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 750);
            this.Controls.Add(this.pcMinimizarMenu);
            this.Controls.Add(this.pcCerrarMenu);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.boxAsistencia);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.Menu_BackgroundImageLayoutChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimizarMenu)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox boxAsistencia;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pcCerrarMenu;
        private System.Windows.Forms.PictureBox pcMinimizarMenu;

    }
}