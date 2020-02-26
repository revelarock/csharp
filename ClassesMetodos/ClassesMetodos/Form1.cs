using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cl_matematica calculadora = new Cl_matematica();

            //int resultado = calculadora.adicao(10, 20);
            // int resultado = calculadora.subratacao(100,50);
            //int resultado = calculadora.subratacao(12, 5);
            int resultado = calculadora.divisao(50, 2);

            caixa_texto.Text = resultado.ToString();

        }
    }
}
