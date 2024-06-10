using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Acoplamento;

public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco(ComportamentoAndar comportamentoAndar)
    {
        _comportamentoAndar = comportamentoAndar;
    }
    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
