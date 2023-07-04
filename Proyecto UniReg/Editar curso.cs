using Datos;
using Microsoft.Win32.SafeHandles;
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
    public partial class Editar_curso : Form
    {
        private string _id;
        private string _facultad;
        private string _dependencia;
        private string _tipo;
        private string _nombre;
        private string _fechaini;
        private string _inimatricula;
        private string _finmatricula;
        private string _semestre;
        private string _horas;
        public Editar_curso(string id, string facultad, string dependencia, string tipo, string nombre, string fechaini, string inimatricula, string finmatricula, string semestre, string horas)
        {
            InitializeComponent();
            _id = id;
            _facultad = facultad;
            _dependencia = dependencia;
            _tipo = tipo;
            _nombre = nombre;
            _fechaini = fechaini;
            _inimatricula = inimatricula;
            _finmatricula = finmatricula;
            _semestre = semestre;
            _horas = horas;
        }

        private void Editar_curso_Load(object sender, EventArgs e)
        {
            dateinimatricula.Value = DateTime.Parse(_inimatricula);
            datefinmatricula.Value = DateTime.Parse(_finmatricula);
            if (_tipo == rdCurso.Text )
            {
                rdCurso.Checked = true;
            }
            else
            {
                rdCapacitacion.Checked = false;
            }
            dateinicio.Value = DateTime.Parse(_fechaini);
            txtnombre.Text = _nombre;
            cbsemestre.Text = _semestre;
            numduracion.Value = decimal.Parse(_horas);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            _fechaini = dateinicio.Value.ToString();
            _inimatricula = dateinimatricula.Value.ToString();
            _finmatricula = datefinmatricula.Value.ToString();
            _semestre = cbsemestre.Text;
            _horas = numduracion.Value.ToString();
            _nombre = txtnombre.Text;
            CD_Cursos.Updatecur(int.Parse(_id), Deftipo(), _nombre, _fechaini, _inimatricula, _finmatricula, _semestre, int.Parse(_horas));
        }

        private string Deftipo()
        {
            if (rdCurso.Checked)
            {
                return rdCurso.Text;
            }
            else
            {
                return rdCapacitacion.Text;
            }
        }
    }
}
