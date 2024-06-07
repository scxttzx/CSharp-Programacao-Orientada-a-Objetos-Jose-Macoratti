using _11Heranca_IsAs;

// -------OPERADOR "as"----------

//Circulo circulo = new Circulo();
//Forma forma = circulo; // upcasting

//// Circulo c = (Circulo)forma;
//Circulo c = forma as Circulo; // downcasting

//if(c != null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Operação de downcasting é inválida");
//}


// -------OPERADOR "as"----------

Circulo circulo2 = new Circulo();
Forma forma1 = circulo2;

if (forma1 is Circulo)
{
    Console.WriteLine("Converteu Forma para Circulo\n");

    //((Circulo)forma1).PintarCirculo();
    var tipo = forma1 as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}

Console.ReadKey();