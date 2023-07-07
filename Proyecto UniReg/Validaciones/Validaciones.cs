using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_UniReg.Validaciones
{
    internal class Validaciones
    {

        public static bool VDatoGenerales(TextBox name1, TextBox apellido1,
                                         TextBox carne, TextBox cedula,
                                         TextBox lugarnacimiento, DateTimePicker fnacimiento)
        {
            //Validacion del campo nombre1
            if (string.IsNullOrWhiteSpace(name1.Text))
            {
                throw new Exception("El campo primer nombre no puede estar vacio");
            }

            //validacion del campo apellido1
            if (apellido1.Text.Length < 3 || string.IsNullOrWhiteSpace(apellido1.Text))
            {
                throw new Exception("El campo primer apellido no puede estar vacio");
            }

            //Validacion del campo cedula
            if (cedula.Text.Length < 14 || string.IsNullOrWhiteSpace(cedula.Text))
            {
                throw new Exception("El campo cedula no puede ser menor a trece digitos");
            }

            //Validacion del campo lugar de nacimiento
            if (string.IsNullOrWhiteSpace(lugarnacimiento.Text))
            {
                throw new Exception("El campo lugar de nacimiento no puede estar vacio");
            }

            //Validacion de fecha de nacimiento
            if (fnacimiento.Value != DateTime.Now && fnacimiento.Value > DateTime.Now)
            {
                throw new Exception("La fecha de nacimiento no puede ser la fecha actual o superior");
            }

            return true;
        }

        //Validacion del apartado informacion laboral
        public static bool VIformacionLaboral(RadioButton rbtnSi, TextBox CentroTrab, TextBox Direccion, TextBox Cargo, TextBox Telefono)
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
                    //string camposFaltantes = string.Join(", ", camposVacios);
                    throw new Exception("¡Faltan campos por rellenar!");
                }
                if (Telefono.Text.Length != 8)
                {
                    int a;
                    if(!int.TryParse(Telefono.Text, out a))
                    {
                        throw new Exception("¡Ingrese datos validos en el campo Telefono!");
                    }   
                }
            }
            return true;
        }
    }

}
