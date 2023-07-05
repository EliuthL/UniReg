using EasyQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_UniReg
{
    public partial class Principal : Form
    {
        private bool sliderStatus = false;
        private bool menustatus = true;
        private System.Windows.Forms.Timer timerFechaActual;

        public Principal()
        {
            InitializeComponent();
            // Configurar el Timer
            timerFechaActual = new Timer();
            timerFechaActual.Interval = 1000; // Intervalo de actualización en milisegundos (en este caso, 1 segundo)
            timerFechaActual.Tick += TimerFechaActual_Tick;
            timerFechaActual.Start();
        }

        private void TimerFechaActual_Tick(object sender, EventArgs e)
        {
            label3.Text = "Fecha y Hora: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        private void DeployMenu()
        {
            if (menustatus == true)
            {

                panelcontainer.Height = 0;
                panelcontainer.Visible = false;
                panelbuttons.Location = new Point(0, 190);
                menustatus = false;
            }
            else
            {
                panelcontainer.Height = 68;
                panelcontainer.Visible = true;
                panelbuttons.Location = new Point(0, 265);
                menustatus = true;
            }
        }
        private void MenuRestar()
        {
            if (menustatus == true)
            {
                panelcontainer.Height = 0;
                panelcontainer.Visible = false;
                panelbuttons.Location = new Point(0, 190);
                menustatus = false;
            }
        }
        internal void ChangeColor(Control controlExeption)
        {
            List<Control> controls1 = new List<Control>()
            {
                Minimizar,
                btncursos,
                btnestudiantes,
                btnmatricular,
                btncrearcurso,
                btnopciones,
                btnnuevamatricula,
                btnestuexist
            };
            if (controlExeption != Minimizar)
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
            ChangeColor(Minimizar);
            MenuRestar();
        }

        private void Click_btnmatricular(object sender, EventArgs e)
        {
            ChangeColor(btnmatricular);
            DeployMenu();
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            VistaForm(new Estudiantes());
            ChangeColor(btnestudiantes);
        }
        private void btncursos_Click(object sender, EventArgs e)
        {
            VistaForm(new Cursos());
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

        private void Principal_Load(object sender, EventArgs e)
        {
            DeployMenu();
            using (SqlCommand command = new SqlCommand("SELECT SUSER_SNAME() AS UserName", Conection.Con))
            {
                string userName = command.ExecuteScalar() as string;
                label1.Text = "Usuario Actual: " + userName;
            }
        }

        private void btnnuevamatricula_Click(object sender, EventArgs e)
        {
            VistaForm(new Matricula());
            ChangeColor(btnnuevamatricula);
            DeployMenu();
        }

        private void btnestuexist_Click(object sender, EventArgs e)
        {
            VistaForm(new EstudiantesExistentes());
            ChangeColor(btnestuexist);
            DeployMenu();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta a punto de cerrar el programa\n ¿Desea cerrarlo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void btnopciones_Click(object sender, EventArgs e)
        {
            VistaForm(new Configuracion());
            ChangeColor(btnopciones);

        }
    }
}
