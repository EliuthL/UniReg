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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelHeat = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.btnopciones = new System.Windows.Forms.Button();
            this.btncrearcurso = new System.Windows.Forms.Button();
            this.btncursos = new System.Windows.Forms.Button();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.btnestuexist = new System.Windows.Forms.Button();
            this.btnnuevamatricula = new System.Windows.Forms.Button();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelHeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelbuttons.SuspendLayout();
            this.panelcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeat
            // 
            this.panelHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelHeat.Controls.Add(this.label3);
            this.panelHeat.Controls.Add(this.label2);
            this.panelHeat.Controls.Add(this.label1);
            this.panelHeat.Controls.Add(this.Minimizar);
            resources.ApplyResources(this.panelHeat, "panelHeat");
            this.panelHeat.Name = "panelHeat";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::Proyecto_UniReg.Properties.Resources.Exapandir_menu;
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.ClickMinimizar);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.panelbuttons);
            this.panelMenu.Controls.Add(this.panelcontainer);
            this.panelMenu.Controls.Add(this.picturePerfil);
            this.panelMenu.Controls.Add(this.btnmatricular);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Red;
            this.panelbuttons.Controls.Add(this.btnestudiantes);
            this.panelbuttons.Controls.Add(this.btnopciones);
            this.panelbuttons.Controls.Add(this.btncrearcurso);
            this.panelbuttons.Controls.Add(this.btncursos);
            resources.ApplyResources(this.panelbuttons, "panelbuttons");
            this.panelbuttons.Name = "panelbuttons";
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnestudiantes.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnestudiantes, "btnestudiantes");
            this.btnestudiantes.Image = global::Proyecto_UniReg.Properties.Resources.Estudiantes;
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = false;
            this.btnestudiantes.Click += new System.EventHandler(this.btnestudiantes_Click);
            // 
            // btnopciones
            // 
            this.btnopciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnopciones.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnopciones, "btnopciones");
            this.btnopciones.Image = global::Proyecto_UniReg.Properties.Resources.configuracion__1_;
            this.btnopciones.Name = "btnopciones";
            this.btnopciones.UseVisualStyleBackColor = false;
            this.btnopciones.Click += new System.EventHandler(this.btnopciones_Click);
            // 
            // btncrearcurso
            // 
            this.btncrearcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncrearcurso.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btncrearcurso, "btncrearcurso");
            this.btncrearcurso.Image = global::Proyecto_UniReg.Properties.Resources.agregar_documento;
            this.btncrearcurso.Name = "btncrearcurso";
            this.btncrearcurso.UseVisualStyleBackColor = false;
            this.btncrearcurso.Click += new System.EventHandler(this.btncrearcurso_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btncursos.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btncursos, "btncursos");
            this.btncursos.Image = global::Proyecto_UniReg.Properties.Resources.Cursos;
            this.btncursos.Name = "btncursos";
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // panelcontainer
            // 
            this.panelcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panelcontainer.Controls.Add(this.btnestuexist);
            this.panelcontainer.Controls.Add(this.btnnuevamatricula);
            resources.ApplyResources(this.panelcontainer, "panelcontainer");
            this.panelcontainer.Name = "panelcontainer";
            // 
            // btnestuexist
            // 
            this.btnestuexist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnestuexist.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnestuexist, "btnestuexist");
            this.btnestuexist.Image = global::Proyecto_UniReg.Properties.Resources.usuario__1_;
            this.btnestuexist.Name = "btnestuexist";
            this.btnestuexist.UseVisualStyleBackColor = false;
            this.btnestuexist.Click += new System.EventHandler(this.btnestuexist_Click);
            // 
            // btnnuevamatricula
            // 
            this.btnnuevamatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnnuevamatricula.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnnuevamatricula, "btnnuevamatricula");
            this.btnnuevamatricula.Image = global::Proyecto_UniReg.Properties.Resources.agregar_usuario;
            this.btnnuevamatricula.Name = "btnnuevamatricula";
            this.btnnuevamatricula.UseVisualStyleBackColor = false;
            this.btnnuevamatricula.Click += new System.EventHandler(this.btnnuevamatricula_Click);
            // 
            // picturePerfil
            // 
            resources.ApplyResources(this.picturePerfil, "picturePerfil");
            this.picturePerfil.Image = global::Proyecto_UniReg.Properties.Resources.Perfil;
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.TabStop = false;
            // 
            // btnmatricular
            // 
            this.btnmatricular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnmatricular.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnmatricular, "btnmatricular");
            this.btnmatricular.Image = global::Proyecto_UniReg.Properties.Resources.Matricular;
            this.btnmatricular.Name = "btnmatricular";
            this.btnmatricular.UseVisualStyleBackColor = false;
            this.btnmatricular.Click += new System.EventHandler(this.Click_btnmatricular);
            // 
            // panelView
            // 
            resources.ApplyResources(this.panelView, "panelView");
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelView.Name = "panelView";
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeat);
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelHeat.ResumeLayout(false);
            this.panelHeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelbuttons.ResumeLayout(false);
            this.panelcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeat;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.Button btnestuexist;
        private System.Windows.Forms.Button btnnuevamatricula;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Button btnopciones;
        private System.Windows.Forms.Button btncrearcurso;
        private System.Windows.Forms.Button btncursos;
    }
}

