using System;
using System.Collections.Generic;
using System.Text;

namespace indiano
{
    internal class Aluno: PessoaFisica
    {
        public String RM;
        public String curso;

        public void ListarAluno(String RM, String curso)
        {
            Console.WriteLine("O portador do RM " + RM
                + " está matriculado no curso " + curso);
        }
    }
        
}
