using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Curso
    {
        public string Id { get; set; }
        public string Facultad { get; set; }
        public string Dependencia { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Fechainicio { get; set; }
        public string Inimatricula { get; set; }
        public string Finmatricula { get; set; }
        public string Duracionhoras { get; set; }
    }
}
