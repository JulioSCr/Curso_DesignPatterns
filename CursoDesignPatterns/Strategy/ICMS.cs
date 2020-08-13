using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICMS : IImposto
    {
        public decimal Calcular(Orcamento pOrcamento)
        {
            return pOrcamento.Valor * 0.5m;
        }
    }
}
