using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Imprimir;

namespace Proyecto_UniReg
{
    public partial class Matricula : Form
    {
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

            if (Validaciones.Validaciones.VDatoGenerales(txtname1, txtapellido1, txtcarne, txtcedula, txtlnacimiento, dtnacimiento) == true
                                                         && Validaciones.Validaciones.VIformacionLaboral(rbsi, txtcentrotrabajo, txtdirecciontrabajo, txtcargo, txtnumerotrabajo) == true)
            {
                ServiciosImpresion.Imprimir(curso, capacitacion, cbcursocapacitacion.Text, lbinicio.Text, lbduracion.Text, txtname1.Text,
                                        txtname2.Text, txtapellido1.Text, txtapellido2.Text, txtcarne.Text, txtcedula.Text, txtlnacimiento.Text,
                                        dtnacimiento.Value.ToString("dd-MM-yyyy"), txtnacionalidad.Text, cbEstadocivil.Text, txtnumerotelefono.Text,
                                        operadora.Text, txtdepartamento.Text, txtmunicipio.Text, txtdirecciondomi.Text, trabaja,
                                        txtcentrotrabajo.Text, txtdirecciontrabajo.Text, txtcargo.Text, txtnumerotrabajo.Text, txtcentroestudio.Text, txtpaisgraduacion.Text,
                                        dtfechatitulacion.Value.ToString("dd-MM-yyyy"), txttitulacionobtenida.Text, txtcarreracursada.Text,
                                        txtcorreo.Text, dateformat, txtnumerorecibo.Text, txtarancel.Text);
            }
            

            


        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            

            lbfechamatricula.Text = dateformat;
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
    }
}
