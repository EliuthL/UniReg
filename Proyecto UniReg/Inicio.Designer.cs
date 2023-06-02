namespace Proyecto_UniReg
{
    partial class Principal
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
            this.panelHeat = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncrearcurso = new System.Windows.Forms.Button();
            this.btncursos = new System.Windows.Forms.Button();
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeat
            // 
            this.panelHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelHeat.Controls.Add(this.label1);
            this.panelHeat.Controls.Add(this.pictureBox2);
            this.panelHeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeat.Location = new System.Drawing.Point(0, 0);
            this.panelHeat.Name = "panelHeat";
            this.panelHeat.Size = new System.Drawing.Size(1122, 30);
            this.panelHeat.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_UniReg.Properties.Resources.Exapandir_menu;
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ClickMinimizar);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btncrearcurso);
            this.panelMenu.Controls.Add(this.btncursos);
            this.panelMenu.Controls.Add(this.btnestudiantes);
            this.panelMenu.Controls.Add(this.picturePerfil);
            this.panelMenu.Controls.Add(this.btnmatricular);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 673);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Proyecto_UniReg.Properties.Resources.Config;
            this.pictureBox3.Location = new System.Drawing.Point(153, 628);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Proyecto_UniReg.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(5, 628);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btncrearcurso
            // 
            this.btncrearcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncrearcurso.FlatAppearance.BorderSize = 0;
            this.btncrearcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearcurso.Image = global::Proyecto_UniReg.Properties.Resources.Matricular;
            this.btncrearcurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrearcurso.Location = new System.Drawing.Point(0, 320);
            this.btncrearcurso.Name = "btncrearcurso";
            this.btncrearcurso.Size = new System.Drawing.Size(200, 53);
            this.btncrearcurso.TabIndex = 4;
            this.btncrearcurso.Text = "Crear curso";
            this.btncrearcurso.UseVisualStyleBackColor = false;
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncursos.FlatAppearance.BorderSize = 0;
            this.btncursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncursos.Image = global::Proyecto_UniReg.Properties.Resources.Cursos;
            this.btncursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.Location = new System.Drawing.Point(0, 267);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(200, 53);
            this.btncursos.TabIndex = 3;
            this.btncursos.Text = "Cursos";
            this.btncursos.UseVisualStyleBackColor = false;
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnestudiantes.FlatAppearance.BorderSize = 0;
            this.btnestudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiantes.Image = global::Proyecto_UniReg.Properties.Resources.Estudiantes;
            this.btnestudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestudiantes.Location = new System.Drawing.Point(0, 217);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(200, 53);
            this.btnestudiantes.TabIndex = 2;
            this.btnestudiantes.Text = "Estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = false;
            // 
            // picturePerfil
            // 
            this.picturePerfil.Image = global::Proyecto_UniReg.Properties.Resources.Perfil;
            this.picturePerfil.Location = new System.Drawing.Point(45, 18);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(100, 100);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfil.TabIndex = 1;
            this.picturePerfil.TabStop = false;
            // 
            // btnmatricular
            // 
            this.btnmatricular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnmatricular.FlatAppearance.BorderSize = 0;
            this.btnmatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatricular.Image = global::Proyecto_UniReg.Properties.Resources.Matricular;
            this.btnmatricular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmatricular.Location = new System.Drawing.Point(0, 167);
            this.btnmatricular.Name = "btnmatricular";
            this.btnmatricular.Size = new System.Drawing.Size(200, 53);
            this.btnmatricular.TabIndex = 0;
            this.btnmatricular.Text = "Matricular";
            this.btnmatricular.UseVisualStyleBackColor = false;
            this.btnmatricular.Click += new System.EventHandler(this.Click_btnmatricular);
            // 
            // panelView
            // 
            this.panelView.AutoScroll = true;
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(200, 30);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(922, 673);
            this.panelView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "UniReg";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 703);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeat);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panelHeat.ResumeLayout(false);
            this.panelHeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btncrearcurso;
        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

