using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class DescontoPorMaisDeQuinhentosReais : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public decimal Desconta(Orcamento pOrcamento)
		{
			if (pOrcamento.Valor > 500) return pOrcamento.Valor * 0.07m;

			return Proximo.Desconta(pOrcamento);
		}
	}
}
