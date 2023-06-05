using System.Data.SqlClient;

namespace EasyQL
{
    public class Estudiante : Model
    {
        public Estudiante(SqlConnection conection) : base(conection)
        {
            Fields.Add("nombres");
            Fields.Add("apellidos");
            Fields.Add("carnet");
            Fields.Add("cedula");
            Fields.Add("lugar_nac");
            Fields.Add("fecha_nac");
            Fields.Add("estado_civil");
            Fields.Add("nacionalidad");
            Fields.Add("telefono");
            Fields.Add("direccion");
            Fields.Add("departamento");
            Fields.Add("municipio");
           
            Table = "Estudiante";
        }
    }
}
