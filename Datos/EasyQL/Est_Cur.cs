using System.Data.SqlClient;

namespace EasyQL
{
    public class Est_Cur : Model
    {
        public Est_Cur(SqlConnection conection) : base(conection)
        {
            Fields.Add("id_estudiante");
            Fields.Add("id_curso");
            Fields.Add("fecha_mat");
            Fields.Add("recibo_no");
            Fields.Add("arancel");

            Table = "Est_Cur";
        }
    }
}
