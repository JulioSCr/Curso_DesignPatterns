using System;

namespace Decorator
{
	public class ICPP : TemplateDeImpostoCondicional
	{
		public ICPP() : base() { }

		public ICPP(Imposto pOutroImposto) : base(pOutroImposto) { }

		protected override bool DeveUsarMaximaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor >= 500;
		}

		protected override decimal MaximaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.07m;
		}

		protected override decimal MinimaTaxacao(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.05m;
		}
	}
}
