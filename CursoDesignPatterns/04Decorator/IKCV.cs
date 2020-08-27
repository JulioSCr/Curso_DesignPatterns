using System;

namespace Decorator
{
	public class IKCV : TemplateDeImpostoCondicional
	{
		public IKCV() : base() { }

		public IKCV(Imposto pOutroImposto) : base(pOutroImposto) { }

		protected override bool DeveUsarMaximaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor > 500 && TemItemMaiorQueMilReaisNo(pOrcamento);
		}

		protected override decimal MaximaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.1m;
		}

		protected override decimal MinimaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.06m;
		}

		private bool TemItemMaiorQueMilReaisNo(Orcamento pOrcamento)
		{
			foreach (Item lItem in pOrcamento.Itens)
			{
				if (lItem.Valor > 1000) return true;
			}
			return false;
		}
	}
}
