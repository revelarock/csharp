using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aula_classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();
            p1.nome = "Joao";
            p1.idade = 42;
            p1.Falar();
            p1.Apresentar_se();

        }
    }
}
