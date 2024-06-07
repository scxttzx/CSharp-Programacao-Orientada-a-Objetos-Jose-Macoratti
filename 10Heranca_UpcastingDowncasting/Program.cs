using _10Heranca_UpcastingDowncasting;


// Upcasting
Forma circulo = new Circulo(10, 20); // upcasting
circulo.Desenhar();

// Outra maneira de upcasting
Circulo circulo2 = new Circulo(10, 20);
Forma forma = circulo2;
forma.Desenhar();

Console.WriteLine(forma == circulo2);

// Downcasting
Circulo circuloDown = new Circulo(20, 20);
Forma f = circuloDown; // upcasting

Circulo c = (Circulo)f; // downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circuloDown);

Console.ReadKey();