using System.Data.SqlClient;

namespace EasyQL
{
    public class Conection
    {
        private static string password;
        private static SqlConnection con;
        private static string server;
        private static string dataBase;
        private static string user;

        public static string Server { get => server; set => server = value; }
        public static string DataBase { get => dataBase; set => dataBase = value; }
        public static string User { get => user; set => user = value; }
        public static string Password { get => password; set => password = value; }
        public static SqlConnection Con { get => con; set => con = value; }

        public static string makeConnectionString()
        {
            if(User != "" && Password != "")
            {
                return $"Data Source={Server};Initial Catalog={DataBase};User ID={User};Password={Password};";
            }
            else if(User == "" && Password == "")
            {
                return $"Data Source={Server};Initial Catalog={DataBase};Integrated Security=true;";
            }
            else
            {
                return null;
            }
        }

        public static SqlConnection makeConnection()
        {
            Con = new SqlConnection(makeConnectionString());
            return Con;
        }
    }
}
