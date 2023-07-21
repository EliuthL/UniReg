using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyQL;
using DotNetEnv;
using System.IO;
using Servicios;
using System.Diagnostics;

namespace Proyecto_UniReg
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conection.User = userTxt.Text;
            Conection.Password = passwordTxt.Text;

            ServicioGuardado servicioGuardado = new ServicioGuardado("DESKTOP-7AD0TBQ", "MatriculaDB");
            Conection.DataBase = servicioGuardado.Datareturn();
            Conection.Server = servicioGuardado.Serverreturn();
           
            try
            {
                Conection.makeConnection(Conection.connectionString());
                Conection.Con.Open();
                Principal principal = new Principal(this);
                principal.Show();

                if (sesionCheck.Checked)
                {
                    string datosAGuardar = userTxt.Text + "," + passwordTxt.Text.ToString();

                    string rutaArchivo = "C:\\Users\\Everth\\Desktop\\UniReg\\Proyecto UniReg\\datos.txt";
                    using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                    {
                        escritor.WriteLine(datosAGuardar);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
        }

        private void userTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTxt.Focus();
            }
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                button1_Click(sender, e);
            }
        }

        private void sesionCheck_CheckedChanged(object sender, EventArgs e)
        {
            string xmlname = "datalogin";
            string phath = Directory.GetCurrentDirectory();
            phath = Path.Combine(phath, xmlname);
            if (!File.Exists(phath))
            {
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string rutaArchivo = "C:\\Users\\Everth\\Desktop\\UniReg\\Proyecto UniReg\\datos.txt";
            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                string linea = lector.ReadLine();

                string[] datos = linea.Split(',');

                if (datos.Count() > 1)
                {
                    string user = datos[0];
                    string password = datos[1];
                    Conection.User = user;
                    Conection.Password = password;

                    ServicioGuardado servicioGuardado = new ServicioGuardado("DESKTOP-7AD0TBQ", "MatriculaDB");
                    Conection.DataBase = servicioGuardado.Datareturn();
                    Conection.Server = servicioGuardado.Serverreturn();

                    try
                    {
                        Conection.makeConnection(Conection.connectionString());
                        Conection.Con.Open();
                        Principal principal = new Principal(this);
                        principal.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
