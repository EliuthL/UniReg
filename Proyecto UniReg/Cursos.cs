using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyQL;

namespace Proyecto_UniReg
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Curso curso = new Curso(Conection.Con);
            DataTable tabla = new DataTable();
            tabla.Load(curso.all());
            dtgcursos.DataSource = tabla;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(Conection.Con);
            try
            {
                if(comboBox1.Text != "" && textBox1.Text != "")
                {
                    string query = $"SELECT * FROM Curso WHERE semestre = '{comboBox1.Text}' AND nombre like '%{textBox1.Text}%'";
                    SqlCommand command = new SqlCommand(query, Conection.Con);
                    command.Parameters.AddWithValue("@Hoy", DateTime.Today);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    dtgcursos.DataSource = tabla;
                }
                if(comboBox1.Text != "")
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(curso.where("semestre", "=", comboBox1.Text));
                    dtgcursos.DataSource = tabla;
                }
                if (textBox1.Text != "")
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(curso.where("nombre", "like", "%"+textBox1.Text+"%"));
                    dtgcursos.DataSource = tabla;
                }
                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = "";
                if(comboBox2.Text == "Fecha de Inicio")
                {
                    tipo = "fecha_ini";
                }
                if (comboBox2.Text == "Inicio de Matricula")
                {
                    tipo = "ini_matricula";
                }
                if (comboBox2.Text == "Fin de Matricula")
                {
                    tipo = "fin_matricula";
                }

                string query = $"SELECT * FROM Curso WHERE {tipo} BETWEEN '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}' and '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                SqlCommand command = new SqlCommand(query, Conection.Con);
                SqlDataReader reader = command.ExecuteReader();

                DataTable tabla = new DataTable();
                tabla.Load(reader);
                dtgcursos.DataSource = tabla;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(Conection.Con);
            DataTable tabla = new DataTable();
            tabla.Load(curso.all());
            dtgcursos.DataSource = tabla;
        }

        private void dtgcursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dtgcursos.Rows.Count -1)
            {
                int id = (int)dtgcursos.Rows[e.RowIndex].Cells["ID"].Value;
                //MessageBox.Show("Se hizo click en la columna con id: " + id);
                curso cur = new curso(id, dtgcursos);
                cur.Show();
            }
        }
    }
}
