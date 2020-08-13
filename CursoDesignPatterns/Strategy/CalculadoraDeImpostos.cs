using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CalculadoraDeImpostos
    {
        public static void RealizaCalculo(Orcamento pOrcamento, IImposto pImposto)
        {
            Console.WriteLine("Valor do imposto {0}", pImposto.Calcular(pOrcamento));
        }
    }
}
