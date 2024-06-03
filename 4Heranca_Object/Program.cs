Classe1 classe = new();

//nada.

Console.ReadKey();

public struct Struct1
{

}

public class Classe1
{

}

public class Classe2 //: Struct1 // Não pode herdar de outra coisa a não ser classe
{

}

public class ClasseDerivada : Classe1
{

}