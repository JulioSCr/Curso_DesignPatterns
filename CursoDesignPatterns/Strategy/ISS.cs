using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class ISS : IImposto
	{
		public decimal Calcular(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.2m;
		}
	}
}
