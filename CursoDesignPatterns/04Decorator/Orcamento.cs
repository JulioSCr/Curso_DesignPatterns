using System.Collections.Generic;

namespace Decorator
{
	public class Orcamento
	{
		public decimal Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public Orcamento(decimal pValor)
		{
			Valor = pValor;
			Itens = new List<Item>();
		}

		public Orcamento(IList<Item> pItens)
		{
			foreach (Item pItem in pItens)
			{
				Valor += pItem.Valor;
			}
			Itens = pItens;
		}

		public void AdicionaItem(Item pItem)
		{
			this.Itens.Add(pItem);
			Valor += pItem.Valor;
		}
	}
}
