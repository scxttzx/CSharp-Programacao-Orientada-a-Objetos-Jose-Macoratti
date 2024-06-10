using _12ClasseAbstrata;

Quadrado q = new();
Console.WriteLine(q.Descricao());

Console.Write("\nInforme a cor da figura: ");
q.Cor = Console.ReadLine();

Console.Write("\nInforme o valor do lado do quadrado: ");
q.Lado = Convert.ToDouble(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado: {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro} m2");

Console.WriteLine($"\nO quadrado tem a cor: {q.Cor}");

Console.ReadKey();

