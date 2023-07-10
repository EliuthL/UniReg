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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_UniReg
{
    public partial class EstudiantesExistentes : Matricula
    {
        public EstudiantesExistentes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


        }
        private void EstudiantesExistentes_Load(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable tabla = new DataTable();
                tabla.Load(est.all());
                dataGridView1.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("cedula", "like", "%" + textBox25.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("carnet", "like", "%" + textBox24.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Estudiante est = new Estudiante(Conection.Con);
                DataTable table = new DataTable();
                table.Load(est.where("CONCAT(nombre1, ' ', nombre2, ' ', apellido1, ' ', apellido2)", "like", "%" + textBox26.Text + "%"));
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
