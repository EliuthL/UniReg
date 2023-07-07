﻿using System;
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
    public partial class curso : Form
    {
        int id;
        DataGridView grid;
        public curso(int Id, DataGridView Grid)
        {
            InitializeComponent();
            id = Id;
            grid = Grid;
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            Curso cur = new Curso(Conection.Con);

            DataTable data = new DataTable();
            data.Load(cur.find(id.ToString()));

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                facultadTxt.Text = Convert.ToString(row["facultad"]);
                dependenciaTxt.Text = Convert.ToString(row["dependencia"]);
                if (Convert.ToString(row["tipo"]) == "Curso")
                {
                    cursoRadio.Checked = true;
                }
                if (Convert.ToString(row["tipo"]) == "Capacitación")
                {
                    capacitacionRadio.Checked = true;
                }
                nombreTxt.Text = Convert.ToString(row["nombre"]);
                ini_cur.Value = Convert.ToDateTime(row["fecha_ini"]);
                ini_mat.Value = Convert.ToDateTime(row["ini_matricula"]);
                fin_mat.Value = Convert.ToDateTime(row["fin_matricula"]);
                numericUpDown1.Value = Convert.ToDecimal(row["duracion_horas"]);
                comboBox1.Text = Convert.ToString(row["semestre"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if(cursoRadio.Checked)
            {
                tipo = "Curso";
            }
            if (capacitacionRadio.Checked)
            {
                tipo = "Capacitación";
            }

            Curso cur = new Curso(Conection.Con);
            List<List<string>> datos = new List<List<string>>()
            {
                new List<string>{ "facultad", facultadTxt.Text },
                new List<string>{ "dependencia", dependenciaTxt.Text },
                new List<string>{ "tipo", tipo },
                new List<string>{ "nombre", nombreTxt.Text },
                new List<string>{ "fecha_ini", ini_cur.Value.ToString("yyyy-MM-dd") },
                new List<string>{ "ini_matricula", ini_mat.Value.ToString("yyyy-MM-dd") },
                new List<string>{ "fin_matricula", fin_mat.Value.ToString("yyyy-MM-dd") },
                new List<string>{ "duracion_horas", numericUpDown1.Value.ToString() },
                new List<string>{ "semestre", comboBox1.Text },
            };

            cur.update(datos, id.ToString());

            DataTable data = new DataTable();
            data.Load(cur.find(id.ToString()));

            if(data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                facultadTxt.Text = Convert.ToString(row["facultad"]);
                dependenciaTxt.Text = Convert.ToString(row["dependencia"]);
                if (Convert.ToString(row["tipo"]) == "Curso")
                {
                    cursoRadio.Checked = true;
                }
                if (Convert.ToString(row["tipo"]) == "Capacitación")
                {
                    capacitacionRadio.Checked = true;
                }
                nombreTxt.Text = Convert.ToString(row["nombre"]);
                ini_cur.Value = Convert.ToDateTime(row["fecha_ini"]);
                ini_mat.Value = Convert.ToDateTime(row["ini_matricula"]);
                fin_mat.Value = Convert.ToDateTime(row["fin_matricula"]);
                numericUpDown1.Value = Convert.ToInt32(row["duracion_horas"]);
                comboBox1.Text = Convert.ToString(row["semestre"]);
            }

            DataTable griddata = new DataTable();
            griddata.Load(cur.all());
            grid.DataSource = griddata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso cur = new Curso(Conection.Con);
            cur.delete(id.ToString());

            DataTable griddata = new DataTable();
            griddata.Load(cur.all());
            grid.DataSource = griddata;

            this.Close();
        }
    }
}
