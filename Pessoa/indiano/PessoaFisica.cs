using System;
using System.Collections.Generic;
using System.Text;

namespace indiano
{
    internal class PessoaFisica
    {
        public String nome;
        public int idade;
        public String cpf;

        public void listardados(String nome, int idade, String cpf)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("CPF: " + cpf);

        }
    }
}
