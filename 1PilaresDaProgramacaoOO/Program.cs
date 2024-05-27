Console.WriteLine("### Herança ###\n");

Pessoa pessoa = new();
Funcionario func = new();
Aluno aluno = new();

pessoa.Nome = "José";
pessoa.Email = "jose@email.com";

func.Empresa = "Google Inc.";
func.Salario = 9000;

aluno.Curso = "Ciência da Computação";
aluno.Nota = 9;

Console.WriteLine("\nPessoa\n");
Console.WriteLine(pessoa.Nome);
Console.WriteLine(pessoa.Email);
pessoa.Identificar();

Console.WriteLine("\nFuncionário\n");
Console.WriteLine(func.Empresa);
Console.WriteLine(func.Salario);
func.Identificar();

Console.WriteLine("\nAluno\n");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Identificar();

Console.ReadLine();

public class Pessoa
{
	public string? Nome { get; set; }
	public string? Email { get; set; }
	public void Identificar()
	{
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
	public decimal Salario { get; set; }
	
}
public class Aluno : Pessoa
{
	public string? Curso { get; set; }
	public int Nota { get; set; }
}