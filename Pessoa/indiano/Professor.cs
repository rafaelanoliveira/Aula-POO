using System;
using System.Collections.Generic;
using System.Text;

namespace indiano
{
    internal class Professor : PessoaFisica
    {
        public String formacao;
        public String cargo;
        public double salario;

        public void listarProfessor(String formacao, String cargo, double salario)
        {
            Console.WriteLine("formacao acadêmica " + formacao);
            Console.WriteLine("Cargo na instituição: " + cargo);
            Console.WriteLine("Salario" + salario);
         }
        public void cadastrardisciplina(String formacao, String cargo, double salario)
        {
            Console.WriteLine("em qual disciplina deseja cadastrar o professor?");
            String disciplina = Console.ReadLine();
            Console.WriteLine("O professor foi cadastrado na disciplina " + disciplina);
        }

    }
}
