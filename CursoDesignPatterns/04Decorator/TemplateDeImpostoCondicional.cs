using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class TemplateDeImpostoCondicional : Imposto
	{
		public TemplateDeImpostoCondicional() : base() { }

		public TemplateDeImpostoCondicional(Imposto pOutroImposto) : base(pOutroImposto) { }

		public override decimal Calcula(Orcamento pOrcamento)
		{
			if (DeveUsarMaximaTaxacao(pOrcamento))
				return MaximaTaxacao(pOrcamento) + CalculoDoOutroImposto(pOrcamento);
			return MinimaTaxacao(pOrcamento) + CalculoDoOutroImposto(pOrcamento);
		}

		protected abstract bool DeveUsarMaximaTaxacao(Orcamento pOrcamento);
		protected abstract decimal MaximaTaxacao(Orcamento pOrcamento);
		protected abstract decimal MinimaTaxacao(Orcamento pOrcamento);
	}
}
