
var gato = new Gato { Nome = "Mingau" };
gato.ExibeNome();

var cao = new Cachorro { Nome = "Rex" };
cao.ExibeNome(); 

Console.ReadKey();

// classe base

class Animal
{
	public string? Nome { get; set; }
	public virtual void ExibeNome()
	{
		Console.WriteLine($"\n Meu nome é {Nome}");
	}
}

class Gato : Animal
{
	public override void ExibeNome()
	{
		Console.WriteLine($"\n Eu sou um gato e meu nome é {Nome}");
	}
}

class Cachorro : Animal
{
	
}