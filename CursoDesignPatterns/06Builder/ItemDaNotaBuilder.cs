using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class ItemDaNotaBuilder
	{
		private string Nome { get; set; }
		private decimal Valor { get; set; }

		public ItemDaNotaBuilder ComNome(string pNome)
		{
			Nome = pNome;
			return this;
		}

		public ItemDaNotaBuilder ComValor(decimal pValor)
		{
			Valor = pValor;
			return this;
		}

		public ItemDaNota Constroi()
		{
			return new ItemDaNota(Nome, Valor);
		}
	}
}
