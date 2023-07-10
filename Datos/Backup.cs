using EasyQL;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace Datos
{
    public class Backup
    {
        public static void CreateBackup(string backuppath)
        {
            string namedb = "MatriculaDB";
            string copy = $"BACKUP-MatriculaDB{DateTime.Now.ToString("yyyy-MM-dd")}.bak";
            string backupcomamnd = $"BACKUP DATABASE [{namedb}] TO DISK = '{Path.Combine(backuppath,copy)}'";

            using (SqlCommand command = new SqlCommand(backupcomamnd, Conection.Con))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
