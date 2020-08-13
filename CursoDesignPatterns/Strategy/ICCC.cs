using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICCC : IImposto
    {
        public decimal Calcular(Orcamento pOrcamento)
        {
            if (pOrcamento.Valor < 1000.00m)
                return pOrcamento.Valor * 0.05m;

            if (pOrcamento.Valor <= 3000 && pOrcamento.Valor >= 1000)
                return pOrcamento.Valor * 0.07m;

            return (pOrcamento.Valor * 0.08m) + 30;
        }
    }
}
