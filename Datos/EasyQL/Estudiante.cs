using System.Data.SqlClient;

namespace EasyQL
{
    public class Estudiante : Model
    {
        public Estudiante(SqlConnection conection) : base(conection)
        {
            Fields.Add("nombre1");
            Fields.Add("nombre2");
            Fields.Add("apellido1");
            Fields.Add("apellido2");
            Fields.Add("carnet");
            Fields.Add("cedula");
            Fields.Add("lugar_nac");
            Fields.Add("fecha_nac");
            Fields.Add("estado_civil");
            Fields.Add("nacionalidad");
            Fields.Add("telefono");
            Fields.Add("operadora");
            Fields.Add("direccion");
            Fields.Add("departamento");
            Fields.Add("municipio");
            Fields.Add("trabaja");
            Fields.Add("centro_trabajo");
            Fields.Add("direccion_trabajo");
            Fields.Add("telefono_trabajo");
            Fields.Add("cargo");
            Fields.Add("centro_estudio");
            Fields.Add("pais");
            Fields.Add("fecha_exp_titulo");
            Fields.Add("titulo");
            Fields.Add("carrera");

            Table = "Estudiante";
        }
    }
}
