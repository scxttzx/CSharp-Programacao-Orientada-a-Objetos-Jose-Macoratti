using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Acoplamento;

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _comportamentoNadar = comportamentoNadar;
    }
    public void Locomocao()
    {
        Console.WriteLine(nameof(Sardinha));
        Console.WriteLine(" Nadando... ");
    }
}
