using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml;

namespace Servicios
{
    public class ServicioGuardado
    {
        static string file = "dataconection.xml";
        static string pathdefault = Directory.GetCurrentDirectory();
        static string filepath = Path.Combine(pathdefault,file);
        static string servername;
        static string databasename;

        public ServicioGuardado(string server, string database)
        {
            servername = server;
            databasename = database;
            WritedData();
        }
        public string Serverreturn()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            using (XmlReader reader = XmlReader.Create(filepath, settings))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "servername")
                        {
                            reader.Read(); // Moverse al contenido del elemento 'server'
                            servername = reader.Value; // Obtener el valor del elemento
                            break; // Salir del bucle una vez que se encuentre el elemento deseado
                        }
                    }
                }
            }
            return servername;
        }

        public string Datareturn()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            using (XmlReader reader = XmlReader.Create(filepath, settings))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "databse")
                        {
                            reader.Read(); // Moverse al contenido del elemento 'databse'
                            databasename = reader.Value; // Obtener el valor del elemento
                            break; // Salir del bucle una vez que se encuentre el elemento deseado
                        }
                    }
                }
            }
            return databasename;
        }

        public void WritedData()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter escritor = XmlWriter.Create(filepath, settings))
            {
                escritor.WriteStartDocument();

                escritor.WriteStartElement("server");

                escritor.WriteStartElement("server");
                escritor.WriteElementString("servername", $"{servername}");
                escritor.WriteElementString("databse", $"{databasename}");
                escritor.WriteEndElement();

                escritor.WriteEndElement();

                escritor.WriteEndDocument();
            }
        }
    }
}
