using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Exercicio_Interfaces;

public class SalvarJson : ArquivoBase, ISalvar
{
    public string NomeArquivo = string.Empty;
    public override void Nome()
    {
        Console.WriteLine("Salvar arquivo em JSON");
    }
    public void Salvar()
    {
        
    }
}
