using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_UniReg
{
    public partial class Principal : Form
    {
        private bool sliderStatus = false;

        public Principal()
        {
            InitializeComponent();
        }
        internal void ChangeColor(Control controlExeption)
        {
            List<Control> controls1 = new List<Control>()
            {
                btncursos,
                btnestudiantes,
                btnmatricular,
                btncrearcurso
            };

            controlExeption.BackColor = Color.FromArgb(255, 100, 0);

            foreach (Control control in controls1)
            {
                if (control != controlExeption)
                {
                    control.BackColor = Color.FromArgb(255, 170, 0);
                }

            }
        }
        public void VistaForm(object formMostrar)
        {
            if (panelView.Controls.Count > 0)
                panelView.Controls.Clear();

            Form form = formMostrar as Form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelView.Controls.Add(form);
            this.panelView.Tag = form;
            form.Show();
        }

        public void Slideer()
        {
            if (sliderStatus == false)
            {
                panelMenu.Width = 45;
                picturePerfil.Size = new Size(40, 40);
                picturePerfil.Location = new Point(2, 10);
                sliderStatus = true;
            }
            else
            {
                panelMenu.Width = 200;
                picturePerfil.Size = new Size(100, 100);
                picturePerfil.Location = new Point(22, 20);
                sliderStatus = false;
            }

        }

        private void ClickMinimizar(object sender, EventArgs e)
        {
            Slideer();
        }

        private void Click_btnmatricular(object sender, EventArgs e)
        {
            VistaForm(new Matricula());
            ChangeColor(btnmatricular);
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            VistaForm(new Estudiantes());
            ChangeColor(btnestudiantes);
        }
        private void btncursos_Click(object sender, EventArgs e)
        {
            ChangeColor(btncursos);
        }
        private void btncrearcurso_Click(object sender, EventArgs e)
        {
            VistaForm(new CrearCurso());
            ChangeColor(btncrearcurso);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
