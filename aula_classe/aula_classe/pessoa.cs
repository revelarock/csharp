using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aula_classe
{
    class pessoa
    {
        public string nome;
        public int idade;
        public string cor_cabelo;

        public void Falar()
        {
            System.Windows.Forms.MessageBox.Show("Olá o meu Nome é: " + nome);

        }

        public void Apresentar_se()
        {
            System.Windows.Forms.MessageBox.Show("O meu Nome é: " + nome + "e tenho " + idade +"Anos");



        }
    }
}
