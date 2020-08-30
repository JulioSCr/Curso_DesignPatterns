using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class ItemDaNota
	{
		public string Nome { get; set; }
		public decimal Valor { get; set; }
		
		public ItemDaNota(string pNome, decimal pValor)
		{
			Nome = pNome;
			Valor = pValor;
		}
	}
}
