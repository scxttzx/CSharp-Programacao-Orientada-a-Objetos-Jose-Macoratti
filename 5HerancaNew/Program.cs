﻿Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Ciência da Computação";
Console.WriteLine(aluno.Saudacao());


Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

class  Aluno : Pessoa
{
    public string? Curso { get; set; }
	public new string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de {Curso}";
}