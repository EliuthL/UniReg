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

namespace Proyecto_UniReg
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.all());
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("cedula", "like", "%" + textBox2.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("carnet", "like", "%" + textBox3.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("CONCAT(nombre1, ' ', nombre2, ' ', apellido1, ' ', apellido2)", "like", "%" + textBox1.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
