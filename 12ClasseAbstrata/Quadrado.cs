using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ClasseAbstrata
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override void CalcularArea() 
        { 
            Area = Math.Sqrt(Lado);
        }
        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
