using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Imprimir;

namespace Proyecto_UniReg
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        
        private void FolderSelect()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string ruttxt = Directory.GetCurrentDirectory();
            ruttxt = Path.Combine(ruttxt, "rutSave.txt");

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string rut = folderBrowserDialog.SelectedPath;

                using (StreamWriter writer = new StreamWriter(ruttxt))
                {
                    writer.Write(string.Empty);
                    writer.Write(rut);
                }

                
            }
        }

        /*public static string RutGenerator(string name)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Configuracion de ruta";
            saveFileDialog.FileName =

            saveFileDialog.Filter = "Archivos de texto (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                string ruttxt = Directory.GetCurrentDirectory();
                ruttxt = Path.Combine(ruttxt, "rutSave.txt");

                using (StreamWriter writer = new StreamWriter(ruttxt))
                {
                    bool statustext = false;
                    using (StreamReader reader = new StreamReader(ruttxt))
                    {
                        string text = reader.ReadToEnd();

                        if (reader.ReadToEnd().Length > 0)
                        {
                            statustext = true;
                        }
                    }
                    writer.Write(rutaArchivo);
                }

                using (StreamReader reader = new StreamReader(ruttxt))
                {
                     rut = reader.ReadToEnd();
                }
            }
            return rut;

        }*/

        private void btnruta_Click(object sender, EventArgs e)
        {
            FolderSelect();
            txtruta.Text = ServiciosImpresion.PdfGetRut();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            if(ServiciosImpresion.PdfGetRut() != "")
            {
                txtruta.Text = ServiciosImpresion.PdfGetRut();
            } 
        }

        private void txtruta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
