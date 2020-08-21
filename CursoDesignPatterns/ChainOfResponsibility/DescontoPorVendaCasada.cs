using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class DescontoPorVendaCasada : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public decimal Desconta(Orcamento pOrcamento)
		{
			if (AconteceuVendaCasada(pOrcamento)) return pOrcamento.Valor * 0.05m;

			return Proximo.Desconta(pOrcamento);
		}

		private static bool AconteceuVendaCasada(Orcamento pOrcamento)
		{
			return VerificaVendaCasada("Lapis", pOrcamento) && VerificaVendaCasada("Caneta", pOrcamento);
		}

		private static bool VerificaVendaCasada(string pNomeItem, Orcamento pOrcamento)
		{
			foreach (Item pItem in pOrcamento.Itens)
			{
				if (pNomeItem.Equals(pItem.Nome))
					return true;
			}
			return false;
		}
	}
}
