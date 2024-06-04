﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8HerancaExercicio;

public class ContaInvestimento : Conta
{
	public override double Juros { get; set; } = 0.009;
	public double Imposto { get; set; } = 0.001;

	private decimal CalculaImposto(double valor)
	{
		return Saldo * (decimal)Imposto;
	}

	public override decimal Sacar(decimal valor)
	{
		if(Saldo >= valor)
		{
			Saldo -= valor - CalculaImposto(Imposto);
			return Saldo;
		}
		else
		{
			Console.WriteLine("Saldo insuficiente");
			return Saldo;
		}
	}
}
