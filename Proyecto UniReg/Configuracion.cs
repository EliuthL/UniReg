using Datos;
using Imprimir;
using System;
using System.IO;
using System.Windows.Forms;

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

        private void RutWriterBackup()
        {
            string ruttxt = Directory.GetCurrentDirectory();
            ruttxt = Path.Combine(ruttxt, "BackupRut.txt");

            using (StreamWriter writer = new StreamWriter(ruttxt))
            {
                writer.Write(string.Empty);
                writer.Write(txtrutbackup.Text);
            }



        }

        private string ReuturnPathBackup()
        {
            string ruttxt = Directory.GetCurrentDirectory();
            ruttxt = Path.Combine(ruttxt, "BackupRut.txt");

            using (StreamReader reader = new StreamReader(ruttxt))
            {
                string backuprut = reader.ReadToEnd();
                return backuprut;
            }
        }


        private void btnruta_Click(object sender, EventArgs e)
        {
            FolderSelect();
            txtruta.Text = ServiciosImpresion.PdfGetRut();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            if (ServiciosImpresion.PdfGetRut() != "")
            {
                txtruta.Text = ServiciosImpresion.PdfGetRut();
            }

            txtrutbackup.Text = ReuturnPathBackup();

        }



        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                Backup.CreateBackup(txtrutbackup.Text);
                MessageBox.Show("El respaldo se realizó con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsaverut_Click(object sender, EventArgs e)
        {
            RutWriterBackup();
        }
    }
}
