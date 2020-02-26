using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caixa_texto_Click(object sender, EventArgs e)
        {

        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            string frase = "Aeroporto Internacional de Belém Val-de-Cães";

           
            caixa_texto.Text = frase + "(Contém" + frase.Length + "letras)";
        }
    }
}
