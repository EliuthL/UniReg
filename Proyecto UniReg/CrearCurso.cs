using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyQL;
using Org.BouncyCastle.Asn1.Crmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_UniReg
{
    public partial class CrearCurso : Form
    {
        public CrearCurso()
        {
            InitializeComponent();
        }

        private void CleanControls()
        {

            textBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            numericUpDown1.ResetText();

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = new Curso(Conection.Con);

                List<string> fields = new List<string>()
                {
                "tipo", "nombre", "fecha_ini", "ini_matricula", "fin_matricula",
                "duracion_horas", "semestre"
                };

                string tipo = "";
                if (radioButton1.Checked == true)
                {
                    tipo = "Curso";
                }
                if (radioButton2.Checked == true)
                {
                    tipo = "Capacitación";
                }
                
                List<string> values = new List<string>()
                {
                tipo, textBox1.Text, ini.Value.ToString("yyyy-MM-dd"), iniMat.Value.ToString("yyyy-MM-dd"),
                finMat.Value.ToString("yyyy-MM-dd"), numericUpDown1.Text, comboBox1.Text
                };

                if(textBox1.Text == "")
                {
                    throw new Exception("Ingrese el nombre del curso");
                }
                if(tipo == "")
                {
                    throw new Exception("Ingrese el tipo del curso");
                }
                if (numericUpDown1.Text == "0")
                {
                    throw new Exception("Ingrese la duración del curso");
                }
                if (comboBox1.Text == "")
                {
                    throw new Exception("Ingrese el semestre del curso");
                }

                curso.insert(fields, values);
                MessageBox.Show("Se ha creado el curso", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanControls();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
