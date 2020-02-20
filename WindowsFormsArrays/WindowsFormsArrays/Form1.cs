using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Executar_Click(object sender, EventArgs e)
        {
            //Arrays

            int[] valores;
            valores = new int[5];

            //Nas Coleções o Índice começa em 0

            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;







        }
    }
}
