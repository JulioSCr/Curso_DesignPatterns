using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class Orcamento
	{
		public decimal Valor { get; set; }

		public Orcamento(decimal pValor)
		{
			this.Valor = pValor;
		}
	}
}
