using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using EasyQL;
using Imprimir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_UniReg
{
    public partial class Matricula : Form
    {
        string cursoId = "";

        public string dateformat = DateTime.Now.ToString("dd-MM-yyyy");
        public Matricula()
        {
            InitializeComponent();
        }
        public void PermitirCamposTrabajo()
        {
            if (rbno.Checked)
            {
                txtcentrotrabajo.Enabled = false;
                txtdirecciontrabajo.Enabled = false;
                txtcargo.Enabled = false;
                txtnumerotrabajo.Enabled = false;
            }
            else
            {
                txtcentrotrabajo.Enabled = true;
                txtdirecciontrabajo.Enabled = true;
                txtcargo.Enabled = true;
                txtnumerotrabajo.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                //insertar datos del estudiante
                Estudiante estudiante = new Estudiante(Conection.Con);
                List<string> fields = new List<string>()
                {
                    "nombre1", "nombre2", "apellido1", "apellido2", "carnet", "cedula",
                    "lugar_nac", "fecha_nac", "estado_civil", "nacionalidad", "telefono", "operadora",
                    "direccion", "departamento", "municipio", "trabaja", "centro_trabajo", "direccion_trabajo",
                    "telefono_trabajo", "cargo", "centro_estudio", "pais", "fecha_exp_titulo", "titulo",
                    "carrera", "email"
                };

                List<string> values = new List<string>()
                {
                    txtname1.Text, txtname2.Text, txtapellido1.Text, txtapellido2.Text, txtcarne.Text, txtcedula.Text,
                    txtlnacimiento.Text, dtnacimiento.Value.ToString("yyyy-MM-dd"), cbEstadocivil.Text, txtnacionalidad.Text, txtnumerotelefono.Text, comboBox3.Text,
                    txtdirecciondomi.Text, txtdepartamento.Text, txtmunicipio.Text, trabaja, txtcentrotrabajo.Text, txtdirecciontrabajo.Text,
                    txtnumerotrabajo.Text, txtcargo.Text, txtcentroestudio.Text, txtpaisgraduacion.Text, dtfechatitulacion.Value.ToString("yyyy-MM-dd"), txttitulacionobtenida.Text,
                    txtcarreracursada.Text, txtcorreo.Text
                };
                estudiante.insert(fields, values);

                //crear la matricula en la base de datos
                string query = "SELECT * FROM Estudiante ORDER BY id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;";
                SqlCommand command = new SqlCommand(query, Conection.Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable datatable = new DataTable();
                datatable.Load(reader);

                string idEstudiante = "";
                if (datatable.Rows.Count > 0)
                {
                    DataRow row = datatable.Rows[0];
                    idEstudiante = row["id"].ToString();
                }
                reader.Close();

                Est_Cur matricula = new Est_Cur(Conection.Con);

                List<string> fie = new List<string>()
                {
                    "id_estudiante", "id_curso", "fecha_mat", "recibo_no", "arancel"
                };
                List<string> val = new List<string>()
                {
                    idEstudiante, cursoId, DateTime.Today.ToString("yyyy-MM-dd"), domainUpDown1.Text, domainUpDown2.Text
                };

                matricula.insert(fie, val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            try
            {
                lbfechamatricula.Text = dateformat;

                string hoy = DateTime.Today.ToString("yyyy-MM-dd");
                string query = $"SELECT * FROM Curso WHERE ini_matricula <= '{hoy}' AND fin_matricula >= '{hoy}'";
                SqlCommand command = new SqlCommand(query, Conection.Con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(4);

                    cbcursocapacitacion.Items.Add($"Id: {id} Nombre: {nombre}");
                }
                reader.Close();
            }
            catch
            {

            }
            
        }

        private void txtdirecciondomi_TextChanged(object sender, EventArgs e)
        {
            txtdirecciondomi.Text.ToUpper();
        }


        //Convertir a mayusculas el texto
        private void txtname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtapellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtapellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtlnacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtnacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtdepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtmunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtdirecciondomi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtcentrotrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtdirecciontrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtcentroestudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtpaisgraduacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txttitulacionobtenida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtcarreracursada_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void rbno_CheckedChanged(object sender, EventArgs e)
        {
            PermitirCamposTrabajo();
        }

        private void txtnumerotrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnumerotelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtcarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnumerorecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtarancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbcursocapacitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string valorSeleccionado = cbcursocapacitacion.SelectedItem.ToString();

                int indiceInicio = valorSeleccionado.IndexOf("Id:") + 4;
                int indiceFin = valorSeleccionado.IndexOf(" ", indiceInicio + 1);

                cursoId = valorSeleccionado.Substring(indiceInicio, indiceFin - indiceInicio);

                Curso cur = new Curso(Conection.Con);
                DataTable data = new DataTable();
                data.Load(cur.find(cursoId));
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    if (Convert.ToString(row["tipo"]) == "Curso")
                        rbcurso.Checked = true;
                    if (Convert.ToString(row["tipo"]) == "Capacitación")
                        rbcapacitacion.Checked = true;

                    lbinicio.Text = Convert.ToDateTime(row["fecha_ini"]).ToString("dd-MM-yyyy");
                    lbduracion.Text = Convert.ToInt32(row["duracion_horas"]).ToString();
                }

                string valorcadena = cbcursocapacitacion.SelectedItem.ToString();
                int indiceInicio2 = valorcadena.IndexOf("Nombre:") + 8;
                string valorNombre = valorcadena.Substring(indiceInicio2);

                System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
                if (comboBox.SelectedItem != null)
                {
                    int indiceSeleccionado = comboBox.SelectedIndex;
                    comboBox.Items[indiceSeleccionado] = valorNombre;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                cbcursocapacitacion.Items.Clear();
                lbfechamatricula.Text = dateformat;

                string hoy = DateTime.Today.ToString("yyyy-MM-dd");
                string query = $"SELECT * FROM Curso WHERE ini_matricula <= '{hoy}' AND fin_matricula >= '{hoy}'";
                SqlCommand command = new SqlCommand(query, Conection.Con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(4);

                    cbcursocapacitacion.Items.Add($"Id: {id} Nombre: {nombre}");
                }
                reader.Close();
            }
            catch
            {

            }
        }
    }
}
