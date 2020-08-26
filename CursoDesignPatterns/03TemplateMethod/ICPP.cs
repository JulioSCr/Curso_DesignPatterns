using System;

namespace TemplateMethod
{
	public class ICPP : TemplateDeImpostoCondicional
	{
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
