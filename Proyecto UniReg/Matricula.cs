using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Imprimir;

namespace Proyecto_UniReg
{
    public partial class Matricula : Form
    {
        

        public Matricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Class1.imprimir();
        }
    }
}
