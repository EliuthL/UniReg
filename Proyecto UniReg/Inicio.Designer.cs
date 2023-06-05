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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btncrearcurso = new System.Windows.Forms.Button();
            this.btncursos = new System.Windows.Forms.Button();
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeat
            // 
            this.panelHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelHeat.Controls.Add(this.label3);
            this.panelHeat.Controls.Add(this.label2);
            this.panelHeat.Controls.Add(this.label1);
            this.panelHeat.Controls.Add(this.Minimizar);
            this.panelHeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeat.Location = new System.Drawing.Point(0, 0);
            this.panelHeat.Name = "panelHeat";
            this.panelHeat.Size = new System.Drawing.Size(1122, 30);
            this.panelHeat.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(990, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "UniReg";
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::Proyecto_UniReg.Properties.Resources.Exapandir_menu;
            this.Minimizar.Location = new System.Drawing.Point(12, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.ClickMinimizar);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btncrearcurso);
            this.panelMenu.Controls.Add(this.btncursos);
            this.panelMenu.Controls.Add(this.btnestudiantes);
            this.panelMenu.Controls.Add(this.picturePerfil);
            this.panelMenu.Controls.Add(this.btnmatricular);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.MaximumSize = new System.Drawing.Size(200, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(200, 680);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 680);
            this.panelMenu.TabIndex = 1;
            // 
            // btncrearcurso
            // 
            this.btncrearcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncrearcurso.FlatAppearance.BorderSize = 0;
            this.btncrearcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearcurso.Image = global::Proyecto_UniReg.Properties.Resources.Matricular;
            this.btncrearcurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrearcurso.Location = new System.Drawing.Point(0, 337);
            this.btncrearcurso.Name = "btncrearcurso";
            this.btncrearcurso.Size = new System.Drawing.Size(200, 53);
            this.btncrearcurso.TabIndex = 4;
            this.btncrearcurso.Text = "Crear curso";
            this.btncrearcurso.UseVisualStyleBackColor = false;
            this.btncrearcurso.Click += new System.EventHandler(this.btncrearcurso_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncursos.FlatAppearance.BorderSize = 0;
            this.btncursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncursos.Image = global::Proyecto_UniReg.Properties.Resources.Cursos;
            this.btncursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.Location = new System.Drawing.Point(0, 284);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(200, 53);
            this.btncursos.TabIndex = 3;
            this.btncursos.Text = "Cursos";
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnestudiantes.FlatAppearance.BorderSize = 0;
            this.btnestudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiantes.Image = global::Proyecto_UniReg.Properties.Resources.Estudiantes;
            this.btnestudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestudiantes.Location = new System.Drawing.Point(0, 234);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(200, 53);
            this.btnestudiantes.TabIndex = 2;
            this.btnestudiantes.Text = "Estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = false;
            this.btnestudiantes.Click += new System.EventHandler(this.btnestudiantes_Click);
            // 
            // picturePerfil
            // 
            this.picturePerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picturePerfil.Image = global::Proyecto_UniReg.Properties.Resources.Perfil;
            this.picturePerfil.Location = new System.Drawing.Point(45, 20);
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
            this.btnmatricular.Location = new System.Drawing.Point(0, 182);
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
            this.panelView.Size = new System.Drawing.Size(922, 680);
            this.panelView.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Proyecto_UniReg.Properties.Resources.Config;
            this.pictureBox1.Location = new System.Drawing.Point(139, 619);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 710);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeat);
            this.MaximumSize = new System.Drawing.Size(1140, 757);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeat.ResumeLayout(false);
            this.panelHeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeat;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btncrearcurso;
        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

