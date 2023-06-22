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
            Conection.DataBase = "MatriculaDB";
            Conection.Server = "MSI\\MSSQLSERVER01";

            try
            {
                Conection.makeConnection(Conection.connectionString());
                Conection.Con.Open();
                Principal principal = new Principal();
                principal.Show();
                this.Hide();

                if (sesionCheck.Checked)
                {

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
    }
}
