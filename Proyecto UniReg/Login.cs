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
            Conection.DataBase = Environment.GetEnvironmentVariable("Server");
            Conection.Server = Environment.GetEnvironmentVariable("Server");
            if (Conection.makeConnection() != null)
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }     
        }
    }
}
