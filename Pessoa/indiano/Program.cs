using indiano;

Console.WriteLine("Você é aluno ou professor?");
String escolaridade = Console.ReadLine();

PessoaFisica pessoa = new PessoaFisica();
Console.WriteLine("Insira o nome: ");
pessoa.nome = Console.ReadLine();
Console.WriteLine("insira a idade");
pessoa.idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("insira o CPF");
pessoa.cpf = Console.ReadLine();

if (escolaridade == "professor" || escolaridade == "Professor")
{
    Professor prof = new Professor();
    Console.WriteLine("insira o nome");
    prof.nome = Console.ReadLine();
    Console.WriteLine("Insira a idade");
    prof.idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o CPF");
    prof.cpf = Console.ReadLine();
    prof.listardados(prof.nome, prof.idade, prof.cpf);
}
else if (escolaridade == "aluno" || escolaridade == "Aluno")
{
    Aluno AL = new Aluno();
    Console.WriteLine("Digite o RM do Aluno");
    AL.RM = Console.ReadLine();
    Console.WriteLine("Digite o curso do Aluno");
    AL.curso = Console.ReadLine();
    AL.ListarAluno(AL.RM, AL.curso);
}