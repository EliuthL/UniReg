using Datos;
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
    public partial class CrearCurso : Form
    {
        public CrearCurso()
        {
            InitializeComponent();
        }
        private void Insert()
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string programa;
            int duration;
            if (rdCurso.Checked)
            {
                programa = rdCurso.Text;
            }
            else
            {
                programa = rdCapacitacion.Text;
            }
            
            CD_Cursos.Insertcur(new Entidades.Cursos{
                Tipo = programa,
                Nombre = txtnombre.Text,
                Fechini = dateinicio.Value.ToString(),
                Inimatricula = dateinimatricula.Value.ToString(),
                Finmatricula = datefinmatricula.Value.ToString(),
                Semestre = cbsemestre.Text,
                Duracion = numduracion.Text
            });



        }
    }
}
