using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto ICMS = new ICMS();
            IImposto ISS = new ISS();

            Orcamento lOrcamento = new Orcamento(500.00m);
            CalculadoraDeImpostos.RealizaCalculo(lOrcamento, ICMS);
            CalculadoraDeImpostos.RealizaCalculo(lOrcamento, ISS);

            Console.ReadKey();
        }
    }
}
