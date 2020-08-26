using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public abstract class TemplateDeImpostoCondicional : IImposto
	{
		public decimal Calcular(Orcamento pOrcamento)
		{
			if (DeveUsarMaximaTaxacao(pOrcamento))
				return MaximaTaxacao(pOrcamento);
			return MinimaTaxacao(pOrcamento);
		}

		protected abstract bool DeveUsarMaximaTaxacao(Orcamento pOrcamento);
		protected abstract decimal MaximaTaxacao(Orcamento pOrcamento);
		protected abstract decimal MinimaTaxacao(Orcamento pOrcamento);
	}
}
