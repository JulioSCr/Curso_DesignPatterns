using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ICMS : Imposto
	{
		public ICMS() : base() { }

		public ICMS(Imposto pOutroImposto) : base(pOutroImposto) { }

		public override decimal Calcula(Orcamento pOrcamento)
		{
			return pOrcamento.Valor * 0.5m + CalculoDoOutroImposto(pOrcamento);
		}
	}
}
