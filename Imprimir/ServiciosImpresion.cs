using NReco.PdfGenerator;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Imprimir
{
    public class ServiciosImpresion
    {

        public static void Imprimir(string curso, string capacitacion, string nombrecurso,
                                    string fechainicio, string duracion,
                                    string name1, string name2,
                                    string apellido1, string apellido2,
                                    string carne, string cedula,
                                    string lugarnacimiento, string fechanacimiento,
                                    string nacionalidad, string estadocivil,
                                    string ntelefono, string operadora,
                                    string departamento, string municipio,
                                    string direcciondomi, string trabaja, string notrabaja,
                                    string centrotrabajo, string dirtrabajo, string cargo,
                                    string teltrabajo, string centrograduacion,
                                    string paisgraduacion, string fechaexpe,
                                    string titulo, string carreracur,
                                    string correo, string fechamatri, string nrecibo,
                                    string arancel)
        {
            var converter = new HtmlToPdfConverter
            {
                Size = PageSize.Letter,
                Orientation = PageOrientation.Portrait,
                Margins = new PageMargins { Left = 1, Right = 1, Top = 1, Bottom = 1 }
            };

            var htmlphat = "C:\\Users\\lopez\\source\\repos\\Proyecto UniReg\\Imprimir\\HojaEstudiante.html";
            string htmlContent = File.ReadAllText(htmlphat);
            htmlContent = htmlContent.Replace("{curso}", curso);
            htmlContent = htmlContent.Replace("{capacitacion}", capacitacion);
            htmlContent = htmlContent.Replace("{nombrecurso}", nombrecurso);
            htmlContent = htmlContent.Replace("{fechaini}", fechainicio);
            htmlContent = htmlContent.Replace("{tduracion}", duracion);
            htmlContent = htmlContent.Replace("{apellido1}", apellido1);
            htmlContent = htmlContent.Replace("{apellido2}", apellido2);
            htmlContent = htmlContent.Replace("{nombre1}", name1);
            htmlContent = htmlContent.Replace("{nombre2}", name2);
            htmlContent = htmlContent.Replace("{carne}", carne);
            htmlContent = htmlContent.Replace("{ncedula}", cedula);
            htmlContent = htmlContent.Replace("{lugarnaci}", lugarnacimiento);
            htmlContent = htmlContent.Replace("{fechanaci}", fechanacimiento);
            htmlContent = htmlContent.Replace("{nacionalida}", nacionalidad);
            htmlContent = htmlContent.Replace("{ecivil}", estadocivil);
            htmlContent = htmlContent.Replace("{ntelefono}", ntelefono);
            htmlContent = htmlContent.Replace("{domiciliar}", direcciondomi);
            htmlContent = htmlContent.Replace("{departamento}", departamento);
            htmlContent = htmlContent.Replace("{municipio}", municipio);
            htmlContent = htmlContent.Replace("{trabaja}", trabaja);
            htmlContent = htmlContent.Replace("{ctrabajo}", centrotrabajo);
            htmlContent = htmlContent.Replace("{direcciont}", dirtrabajo);
            htmlContent = htmlContent.Replace("{cargo}", cargo);
            htmlContent = htmlContent.Replace("{telefonot}", teltrabajo);
            htmlContent = htmlContent.Replace("{cgraduacion}", centrograduacion);
            htmlContent = htmlContent.Replace("{paisgradua}", paisgraduacion);
            htmlContent = htmlContent.Replace("{fexpedi}", fechaexpe);
            htmlContent = htmlContent.Replace("{carreracur}", carreracur);
            htmlContent = htmlContent.Replace("{titulo}", titulo);
            htmlContent = htmlContent.Replace("{correo}", correo);
            htmlContent = htmlContent.Replace("{fmatricula}", fechamatri);
            htmlContent = htmlContent.Replace("{nrecibo}", nrecibo);
            htmlContent = htmlContent.Replace("{arancel}", arancel);
            


            var pdfBytes = converter.GeneratePdf(htmlContent);

            string pdffilePath = $"C:\\Users\\lopez\\OneDrive\\Escritorio\\New folder (4)\\{name1 + apellido1 + cedula}.pdf";
            File.WriteAllBytes(pdffilePath, pdfBytes);

            Process.Start(pdffilePath);
        }
        public void ExelGenerator()
        {

        }
    }
}
