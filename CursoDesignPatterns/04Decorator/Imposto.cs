using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Imposto
	{
		public Imposto OutroImposto { get; set; }

		public Imposto() 
		{
			this.OutroImposto = null;
		}

		public Imposto(Imposto pImposto)
		{
			OutroImposto = pImposto;
		}

		public abstract decimal Calcula(Orcamento pOrcamento);

		protected decimal CalculoDoOutroImposto(Orcamento pOrcamento)
		{
			if (OutroImposto == null) return 0;
			return OutroImposto.Calcula(pOrcamento);
		}
	}
}
