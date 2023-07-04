using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Proyecto_UniReg
{
    public partial class Cursos : Form
    {
        DataTable dt = new DataTable();

        public void Actualizardtg()
        {
            Actualizar();
        }

        public void Actualizar()
        {
            dt.Clear();
            foreach (var data in CD_Cursos.Cursosreturner())
            {
                dt.Rows.Add(data.Id, data.Facultad, data.Dependencias, data.Tipo, data.Nombre, data.Fechini, data.Inimatricula, data.Finmatricula, data.Semestre, data.Duracion);
            }

            dtgcursos.DataSource = dt;
        }
        public Cursos()
        {
            InitializeComponent();
            
            dt.Columns.Add("Id");
            dt.Columns.Add("Facultad");
            dt.Columns.Add("Dependencia");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha de inicio");
            dt.Columns.Add("Inicio matricula");
            dt.Columns.Add("Fin matricula");
            dt.Columns.Add("Semestre");
            dt.Columns.Add("Horas de duracion");
            
            foreach (var data in CD_Cursos.Cursosreturner())
            {
                dt.Rows.Add(data.Id,data.Facultad,data.Dependencias, data.Tipo, data.Nombre, data.Fechini, data.Inimatricula, data.Finmatricula, data.Semestre, data.Duracion);
            }

            dtgcursos.DataSource = dt;
            Editar_curso editar_Curso = new Editar_curso();
            editar_Curso.ExecuteUpdate += Actualizardtg;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCurso crearCurso = new CrearCurso();
            crearCurso.Show();
        }

        private void dtgcursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgcursos.RowCount - 1)
            {
                DataGridViewRow row = dtgcursos.Rows[e.RowIndex];


                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            Editar_curso editar_Curso = new Editar_curso(row.Cells["Id"].Value.ToString(), row.Cells["Facultad"].Value.ToString(), row.Cells["Dependencia"].Value.ToString(), row.Cells["Tipo"].Value.ToString(), row.Cells["Nombre"].Value.ToString(), row.Cells["Fecha de inicio"].Value.ToString(), row.Cells["Inicio matricula"].Value.ToString(), row.Cells["Fin matricula"].Value.ToString(), row.Cells["Semestre"].Value.ToString(), row.Cells["Horas de duracion"].Value.ToString());
                            editar_Curso.Show();
                            break;
                        }

                    case 1:
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una celda valida");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                dt.Clear();
                foreach (var data in CD_Cursos.SelectWhere(int.Parse(textBox2.Text)))
                {
                    dt.Rows.Add(data.Id, data.Facultad, data.Dependencias, data.Tipo, data.Nombre, data.Fechini, data.Inimatricula, data.Finmatricula, data.Semestre, data.Duracion);
                }

                dtgcursos.DataSource = dt;
            }
            else
            {
                dt.Clear();
                foreach (var data in CD_Cursos.Cursosreturner())
                {
                    dt.Rows.Add(data.Id, data.Facultad, data.Dependencias, data.Tipo, data.Nombre, data.Fechini, data.Inimatricula, data.Finmatricula, data.Semestre, data.Duracion);
                }

                dtgcursos.DataSource = dt;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
