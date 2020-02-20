using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsCiclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //For

            //for (int valor = 0; valor <= 100; valor++)
            //{ 
            //    listBox1.Items.Add(valor);
            //}

            //int vezes = 0;
            //while (vezes <100)

            //{
            //    listBox1.Items.Add(vezes);
            //    vezes++;
            //}

            //listBox1.Items.Clear();

            //int vezes = 0;
            //do
            //{
            //    listBox1.Items.Add(vezes);
            //    vezes++;
            //} while (vezes <=100);

            string frase = "Este Ciclo é fantastico";

            //listBox1.Items.Add(frase);
            //listBox1.Items.Add(frase.ToUpper());
            //listBox1.Items.Add(frase.Length);

            List<string> lista_nome = new List<string>()
            {
                "Joao","Antonio","Franscisco","Carlos","Ana","Patricia","Ana"
            };

            foreach (string s in lista_nome)
            {
                listBox1.Items.Add(s);
            }
            //foreach (char c in frase)
                            
            //{
            //    listBox1.Items.Add(c);
            //}

            }
        }
    
}
