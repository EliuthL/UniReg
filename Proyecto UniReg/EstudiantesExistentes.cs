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
using Imprimir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_UniReg
{
    public partial class EstudiantesExistentes : Matricula
    {
        int idEstudiante = 0;

        public EstudiantesExistentes()
        {
            InitializeComponent();
        }

        protected override void btnguardar_Click(object sender, EventArgs e)
        {
            //obtener datos de los radio butons
            string curso = "";
            string capacitacion = "";
            string trabaja = "";
            if (rbcurso.Checked)
            {
                curso = "X";
            }
            else
            {
                capacitacion = "X";
            }

            if (rbsi.Checked)
            {
                trabaja = "SI";
            }
            else
            {
                trabaja = "NO";
            }

            try
            {
                //imprimir hoja de matricula
                if (Validaciones.Validaciones.VDatoGenerales(txtname1, txtapellido1, txtcarne, txtcedula, txtlnacimiento, dtnacimiento) == true
                                                         && Validaciones.Validaciones.VIformacionLaboral(rbsi, txtcentrotrabajo, txtdirecciontrabajo, txtcargo, txtnumerotrabajo) == true)
                {
                    ServiciosImpresion.Imprimir(curso, capacitacion, cbcursocapacitacion.Text, lbinicio.Text, lbduracion.Text, txtname1.Text,
                                            txtname2.Text, txtapellido1.Text, txtapellido2.Text, txtcarne.Text, txtcedula.Text, txtlnacimiento.Text,
                                            dtnacimiento.Value.ToString("dd-MM-yyyy"), txtnacionalidad.Text, cbEstadocivil.Text, txtnumerotelefono.Text,
                                            operadora.Text, txtdepartamento.Text, txtmunicipio.Text, txtdirecciondomi.Text, trabaja,
                                            txtcentrotrabajo.Text, txtdirecciontrabajo.Text, txtcargo.Text, txtnumerotrabajo.Text, txtcentroestudio.Text, txtpaisgraduacion.Text,
                                            dtfechatitulacion.Value.ToString("dd-MM-yyyy"), txttitulacionobtenida.Text, txtcarreracursada.Text,
                                            txtcorreo.Text, dateformat, domainUpDown1.Text, domainUpDown2.Text);
                }

                Est_Cur matricula = new Est_Cur(Conection.Con);

                List<string> fie = new List<string>()
                {
                    "id_estudiante", "id_curso", "fecha_mat", "recibo_no", "arancel"
                };
                List<string> val = new List<string>()
                {
                    idEstudiante.ToString(), cursoId.ToString(), DateTime.Today.ToString("yyyy-MM-dd"), domainUpDown1.Text, domainUpDown2.Text
                };

                matricula.insert(fie, val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                idEstudiante = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                txtname1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["nombre1"].Value;
                txtname2.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["nombre2"].Value;
                txtapellido1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["apellido1"].Value;
                txtapellido2.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["apellido2"].Value;
                txtcarne.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["carnet"].Value;
                txtcedula.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value;
                txtlnacimiento.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["lugar_nac"].Value;
                dtnacimiento.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["fecha_nac"].Value;
                txtnacionalidad.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["nacionalidad"].Value;
                cbEstadocivil.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["estado_civil"].Value;
                txtnumerotelefono.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["telefono"].Value;
                comboBox3.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["operadora"].Value;
                txtdepartamento.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["departamento"].Value;
                txtmunicipio.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["municipio"].Value;
                txtdirecciondomi.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["direccion"].Value;
                txtcorreo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["email"].Value;

                if ((string)dataGridView1.Rows[e.RowIndex].Cells["trabaja"].Value == "SI")
                {
                    rbsi.Checked = true;
                }
                if ((string)dataGridView1.Rows[e.RowIndex].Cells["trabaja"].Value == "NO")
                {
                    rbno.Checked = true;
                }
                txtcentrotrabajo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["centro_trabajo"].Value;
                txtdirecciontrabajo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["direccion_trabajo"].Value;
                txtcargo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value;
                txtnumerotrabajo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["telefono_trabajo"].Value;

                txtcentroestudio.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["centro_estudio"].Value;
                txtpaisgraduacion.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["pais"].Value;
                dtfechatitulacion.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["fecha_exp_titulo"].Value;
                txttitulacionobtenida.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["titulo"].Value;
                txtcarreracursada.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["carrera"].Value;
            }
        }
    }
}
