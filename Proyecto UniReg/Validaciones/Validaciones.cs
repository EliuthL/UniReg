using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_UniReg.Validaciones
{
    internal class Validaciones
    {

        public static void VDatoGenerales(TextBox name1, TextBox apellido1,
                                         TextBox carne, TextBox cedula,
                                         TextBox lugarnacimiento, DateTimePicker fnacimiento)
        {
            //Validacion del campo nombre1
            if (string.IsNullOrWhiteSpace(name1.Text))
            {
                MessageBox.Show("El campo primer nombre no puede estar vacio",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //validacion del campo apellido1
            if (apellido1.Text.Length < 3 || string.IsNullOrWhiteSpace(apellido1.Text))
            {
                MessageBox.Show("El campo primer apellido no puede estar vacio",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //validacion del campo carne por numeero de caracteres y caracteres permitidos
            if (string.IsNullOrWhiteSpace(carne.Text) || carne.Text.Length < 8)
            {
                MessageBox.Show("El campo carne no puede estar vacio \n o ser menor a ocho digitos",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                char[] numeros = carne.Text.ToCharArray();
                foreach (char c in numeros)
                {
                    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4'
                        || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                    }
                    else
                    {
                        MessageBox.Show("El campo carne no pude incluir letras",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }

            //Validacion del campo cedula
            if (cedula.Text.Length < 14 || string.IsNullOrWhiteSpace(cedula.Text))
            {
                MessageBox.Show("El campo cedula no puede ser menor a trece digitos",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Validacion del campo lugar de nacimiento
            if (string.IsNullOrWhiteSpace(lugarnacimiento.Text))
            {
                MessageBox.Show("El campo lugar de nacimiento no puede estar vacio",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Validacion de fecha de nacimiento
            if (fnacimiento.Value == DateTime.Now || fnacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser la fecha actual o superior",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        //Validacion del apartado informacion laboral
        public static void VIformacionLaboral(RadioButton rbtnSi, TextBox CentroTrab, TextBox Direccion, TextBox Cargo, TextBox Telefono)
        {
            List<string> camposVacios = new List<string>();
            if (string.IsNullOrWhiteSpace(CentroTrab.Text))
            {
                camposVacios.Add("");
            }
            if (string.IsNullOrWhiteSpace(Direccion.Text))
            {
                camposVacios.Add("");
            }
            if (string.IsNullOrWhiteSpace(Cargo.Text))
            {
                camposVacios.Add("");
            }
            if (string.IsNullOrWhiteSpace(Telefono.Text))
            {
                camposVacios.Add("");
            }

            //Validacion de que todos los campos esten llenos
            if (rbtnSi.Checked)
            {
                if (camposVacios.Count > 0)
                {
                    string camposFaltantes = string.Join(", ", camposVacios);
                    MessageBox.Show("¡Faltan campos por rellenar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (rbtnSi.Checked)
            {
                if (camposVacios.Count == 0)
                {

                    MessageBox.Show("¡Ingrese datos validos en el campo Telefono!", "Advertencia",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }

}
