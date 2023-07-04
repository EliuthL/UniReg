using EasyQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Net.NetworkInformation;
using System.Windows.Input;

namespace Datos
{
    public class CD_Cursos
    {
        public static List<Cursos> Cursosreturner()
        {
            var list = new List<Cursos>();
            using(SqlConnection conection = new SqlConnection(Conection.connectionString()))
            {
                string querylistcur = "SELECT * FROM Curso;";
                SqlCommand comand = new SqlCommand(querylistcur, conection);
                comand.CommandType = CommandType.Text;
                conection.Open();
                using (SqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Cursos
                        {
                            Id = reader["id"].ToString(),
                            Facultad = reader["facultad"].ToString(),
                            Dependencias = reader["dependencia"].ToString(),
                            Tipo = reader["tipo"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Fechini = reader["fecha_ini"].ToString(),
                            Inimatricula = reader["ini_matricula"].ToString(),
                            Finmatricula = reader["fin_matricula"].ToString(),
                            Semestre = reader["Semestre"].ToString(),
                            Duracion = reader["duracion_horas"].ToString()
                        });
                    }
                }



            }
            return list;
        }

        public static void Insertcur(Cursos datacursos)
        {
            using (SqlConnection conection = new SqlConnection(Conection.connectionString()))
            {
                string insertquery = $"INSERT INTO Curso(tipo,nombre,fecha_ini,ini_matricula,fin_matricula,Semestre,duracion_horas) VALUES (@tipo,@nombre, @fechaini, @inimatricula,@finmatricula,@semestre, @duracion)";
                try
                {
                    using (SqlCommand comand = new SqlCommand(insertquery, conection))
                    {
                        comand.Parameters.AddWithValue("@tipo", datacursos.Tipo);
                        comand.Parameters.AddWithValue("@nombre", datacursos.Nombre);
                        comand.Parameters.AddWithValue("@fechaini", datacursos.Fechini);
                        comand.Parameters.AddWithValue("@inimatricula", datacursos.Inimatricula);
                        comand.Parameters.AddWithValue("@finmatricula", datacursos.Finmatricula);
                        comand.Parameters.AddWithValue("@semestre", datacursos.Semestre);
                        comand.Parameters.AddWithValue("@duracion", int.Parse(datacursos.Duracion));
                        conection.Open();
                        comand.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        public static List<Cursos> SelectWhere(int id)
        {
            var list = new List<Cursos>();
            using (SqlConnection conection = new SqlConnection(Conection.connectionString()))
            {
                string querylistcur = $"SELECT * FROM Curso  WHERE id = {id}";
                SqlCommand comand = new SqlCommand(querylistcur, conection);
                comand.CommandType = CommandType.Text;
                conection.Open();
                using (SqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Cursos
                        {
                            Id = reader["id"].ToString(),
                            Facultad = reader["facultad"].ToString(),
                            Dependencias = reader["dependencia"].ToString(),
                            Tipo = reader["tipo"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Fechini = reader["fecha_ini"].ToString(),
                            Inimatricula = reader["ini_matricula"].ToString(),
                            Finmatricula = reader["fin_matricula"].ToString(),
                            Semestre = reader["Semestre"].ToString(),
                            Duracion = reader["duracion_horas"].ToString()
                        });
                    }
                }
                return list;
            }
        }
        public static void Updatecur(int id, string tipo, string nombre, string fechaini, string inimatricula, string finmatri, string semestre, int duracion)
        {
            using (SqlConnection connection = new SqlConnection(Conection.connectionString()))
            {
                string queryUpdate = "UPDATE Curso SET tipo = @Tipo, nombre = @Nombre, fecha_ini = @FechaIni, ini_matricula = @IniMatricula, " +
                    "fin_matricula = @FinMatricula, Semestre = @Semestre, duracion_horas = @Duracion WHERE id = @Id";

                SqlCommand command = new SqlCommand(queryUpdate, connection);
                command.Parameters.AddWithValue("@Tipo", tipo);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@FechaIni", fechaini);
                command.Parameters.AddWithValue("@IniMatricula", inimatricula);
                command.Parameters.AddWithValue("@FinMatricula", finmatri);
                command.Parameters.AddWithValue("@Semestre", semestre);
                command.Parameters.AddWithValue("@Duracion", duracion);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
