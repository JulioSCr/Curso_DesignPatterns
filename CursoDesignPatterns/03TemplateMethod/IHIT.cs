using System.Collections.Generic;
using System.Linq;

namespace TemplateMethod
{
	public class IHIT : TemplateDeImpostoCondicional
	{
		protected override bool DeveUsarMaximaTaxacao(Orcamento pOrcamento)
		{
			foreach (Item lItem in pOrcamento.Itens)
			{
				IList<Item> lItens = pOrcamento.Itens.Where(x => x.Nome == lItem.Nome).ToList();
				if (lItens.Count > 1)
					return true;
			}
			return false;
		}

		protected override decimal MaximaTaxacao(Orcamento pOrcamento)
		{
			return (pOrcamento.Valor * 0.13m) + 100;
		}

		protected override decimal MinimaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.01m * pOrcamento.Itens.Count;
		}
	}
}
