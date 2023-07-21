namespace Proyecto_UniReg
{
    partial class Configuracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnruta = new System.Windows.Forms.Button();
            this.lbrut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnsaverut = new System.Windows.Forms.Button();
            this.txtrutbackup = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuraciones";
            // 
            // txtruta
            // 
            this.txtruta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtruta.Enabled = false;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(18, 68);
            this.txtruta.Margin = new System.Windows.Forms.Padding(2);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(634, 23);
            this.txtruta.TabIndex = 1;
            this.txtruta.TextChanged += new System.EventHandler(this.txtruta_TextChanged);
            // 
            // btnruta
            // 
            this.btnruta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnruta.Location = new System.Drawing.Point(664, 68);
            this.btnruta.Margin = new System.Windows.Forms.Padding(2);
            this.btnruta.Name = "btnruta";
            this.btnruta.Size = new System.Drawing.Size(93, 22);
            this.btnruta.TabIndex = 2;
            this.btnruta.Text = "Seleccionar";
            this.btnruta.UseVisualStyleBackColor = true;
            this.btnruta.Click += new System.EventHandler(this.btnruta_Click);
            // 
            // lbrut
            // 
            this.lbrut.AutoSize = true;
            this.lbrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrut.Location = new System.Drawing.Point(16, 53);
            this.lbrut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrut.Name = "lbrut";
            this.lbrut.Size = new System.Drawing.Size(268, 13);
            this.lbrut.TabIndex = 3;
            this.lbrut.Text = "Ruta donde se guadaran las matriculas en pdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta donde se guadarán los respaldos de la base de datos";
            // 
            // btnbackup
            // 
            this.btnbackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbackup.Location = new System.Drawing.Point(664, 188);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(124, 27);
            this.btnbackup.TabIndex = 7;
            this.btnbackup.Text = "Crear respaldo";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnsaverut
            // 
            this.btnsaverut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaverut.Location = new System.Drawing.Point(664, 150);
            this.btnsaverut.Name = "btnsaverut";
            this.btnsaverut.Size = new System.Drawing.Size(124, 28);
            this.btnsaverut.TabIndex = 8;
            this.btnsaverut.Text = "Guradar ruta";
            this.btnsaverut.UseVisualStyleBackColor = true;
            this.btnsaverut.Click += new System.EventHandler(this.btnsaverut_Click);
            // 
            // txtrutbackup
            // 
            this.txtrutbackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrutbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrutbackup.Location = new System.Drawing.Point(24, 151);
            this.txtrutbackup.Name = "txtrutbackup";
            this.txtrutbackup.Size = new System.Drawing.Size(634, 23);
            this.txtrutbackup.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrutbackup);
            this.Controls.Add(this.btnsaverut);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbrut);
            this.Controls.Add(this.btnruta);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btnruta;
        private System.Windows.Forms.Label lbrut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnsaverut;
        private System.Windows.Forms.TextBox txtrutbackup;
        private System.Windows.Forms.Button button1;
    }
}