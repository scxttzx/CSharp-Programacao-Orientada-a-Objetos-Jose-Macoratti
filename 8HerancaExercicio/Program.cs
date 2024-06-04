﻿
using _8HerancaExercicio;

Console.WriteLine("\nConta corrente: Número: 111 Titular: Maria");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta: {conta.Saldo.ToString("c")}");

Console.ReadKey();

Console.WriteLine("\nConta Poupança: Numero: 222 Titular: José");
ContaPoupanca contaPoupanca = new();
contaPoupanca.Numero = 222;
contaPoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta Poupança: {contaPoupanca.Saldo.ToString("c")}");

Console.ReadKey();

Console.WriteLine("\nConta Investimento: Numero: 333 Titular: Ana");
ContaInvestimento contaInvestimento = new();
contaInvestimento.Numero = 333;
contaInvestimento.Titular = "Ana";

Console.WriteLine("Depositando R$ 1000,00");
contaInvestimento.Depositar(1000);
Console.WriteLine($"Saldo da Conta Investimento: {contaInvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100,00");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta Investimento: {contaInvestimento.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2.000,00");
contaInvestimento.Sacar(2000);
Console.WriteLine($"Saldo da Conta Investimento: {contaInvestimento.Saldo.ToString("c")}");

Console.ReadKey();