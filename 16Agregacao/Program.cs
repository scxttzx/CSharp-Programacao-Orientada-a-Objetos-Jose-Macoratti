using _16Agregacao;

Professor prof1 = new("Carlos", "Química");
Professor prof2 = new("Maira", "Inglês");
Professor prof3 = new("Ana", "Literatura");
Professor prof4 = new("Paulo", "Matemática");

Departamento dp1 = new("Exatas");
dp1.IncluirProfessor(prof1);
dp1.IncluirProfessor(prof4);
dp1.ListaPRofessores();

Departamento dp2 = new("Humanas");
dp2.IncluirProfessor(prof2);
dp2.IncluirProfessor(prof3);
dp2.ListaPRofessores();

Console.ReadKey();