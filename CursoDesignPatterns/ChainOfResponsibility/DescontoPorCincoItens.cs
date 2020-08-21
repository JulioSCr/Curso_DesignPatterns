using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class DescontoPorCincoItens : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public decimal Desconta(Orcamento pOrcamento)
		{
			if (pOrcamento.Itens.Count > 5) return pOrcamento.Valor * 0.1m;

			return Proximo.Desconta(pOrcamento);
		}
	}
}
