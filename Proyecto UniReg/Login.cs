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
            Env.Load();
            Conection.DataBase = Environment.GetEnvironmentVariable("Data_Base");
            Conection.Server = Environment.GetEnvironmentVariable("Server");

            try
            {
                Conection.makeConnection();
                Conection.Con.Open();
                Principal principal = new Principal();
                principal.Show();
                this.Hide();

                //if (sesionRbt.Checked)
                //{

                //}
            }
            catch
            {
                MessageBox.Show("La contreseña o el Usuario son incorrectas");
            }       
        }
    }
}
