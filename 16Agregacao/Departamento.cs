﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Agregacao;

internal class Departamento
{

    public string? Nome { get; set; }
    private List<Professor>? professores {  get; set; }
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }
    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor);
    }
    public void ListaPRofessores()
    {
        Console.WriteLine($"Departamento de: {Nome}");

        foreach(var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }
}
