using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class Item
	{
		public string Nome { get; private set; }
		public decimal Valor { get; private set; }

		public Item(string pNome, decimal pValor)
		{
			this.Nome = pNome;
			this.Valor = pValor;
		}
	}
}
