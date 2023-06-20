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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuraciones";
            // 
            // txtruta
            // 
            this.txtruta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtruta.Enabled = false;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(24, 84);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(634, 27);
            this.txtruta.TabIndex = 1;
            // 
            // btnruta
            // 
            this.btnruta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnruta.Location = new System.Drawing.Point(664, 84);
            this.btnruta.Name = "btnruta";
            this.btnruta.Size = new System.Drawing.Size(124, 27);
            this.btnruta.TabIndex = 2;
            this.btnruta.Text = "Seleccionar";
            this.btnruta.UseVisualStyleBackColor = true;
            this.btnruta.Click += new System.EventHandler(this.btnruta_Click);
            // 
            // lbrut
            // 
            this.lbrut.AutoSize = true;
            this.lbrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrut.Location = new System.Drawing.Point(21, 65);
            this.lbrut.Name = "lbrut";
            this.lbrut.Size = new System.Drawing.Size(325, 16);
            this.lbrut.TabIndex = 3;
            this.lbrut.Text = "Ruta donde se guadaran las matriculas en pdf";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbrut);
            this.Controls.Add(this.btnruta);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label1);
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
    }
}