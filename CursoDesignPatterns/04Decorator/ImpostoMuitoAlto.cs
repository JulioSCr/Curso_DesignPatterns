using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ImpostoMuitoAlto : Imposto
	{
		public ImpostoMuitoAlto() : base() { }

		public ImpostoMuitoAlto(Imposto pOutroImposto) : base(pOutroImposto) { }

		public override decimal Calcula(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.2m + CalculoDoOutroImposto(pOrcamento);
		}
	}
}
