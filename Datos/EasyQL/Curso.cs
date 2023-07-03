using System.Data.SqlClient;

namespace EasyQL
{
    public class Curso : Model
    {
        public Curso(SqlConnection conection) : base(conection)
        {
            Fields.Add("facultad");
            Fields.Add("dependencia");
            Fields.Add("tipo");
            Fields.Add("nombre");
            Fields.Add("fecha_ini");
            Fields.Add("ini_matricula");
            Fields.Add("fin_matricula");
            Fields.Add("duracion_horas");
            Fields.Add("semestre");

            Table = "Curso";
        }
    }
}
