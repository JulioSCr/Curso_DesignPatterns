using System;
using System.Collections.Generic;

namespace State
{
	public class Orcamento
	{
		public decimal Valor { get; set; }
		public IList<Item> Itens { get; private set; }
		public IEstadoOrcamento Estado { get; set; }
		private bool DescontoAplicado = false;

		public Orcamento(decimal pValor)
		{
			Valor = pValor;
			Itens = new List<Item>();
			Estado = new EmAprovacao();
		}

		public Orcamento(IList<Item> pItens)
		{
			foreach (Item pItem in pItens)
			{
				Valor += pItem.Valor;
			}
			Itens = pItens;
			Estado = new EmAprovacao();
		}

		public void AdicionaItem(Item pItem)
		{
			this.Itens.Add(pItem);
			Valor += pItem.Valor;
		}

		public void AplicaDescontoExtra()
		{
			if (DescontoAplicado) throw new Exception("Desconto já foi aplicado.");
			Estado.AplicaDescontoExtra(this);
			DescontoAplicado = true;
		}

		public void Aprova()
		{
			Estado.Aprova(this);
			DescontoAplicado = false;
		}

		public void Finaliza()
		{
			Estado.Finaliza(this);
			DescontoAplicado = false;
		}

		public void Reprova()
		{
			Estado.Reprova(this);
			DescontoAplicado = false;
		}
	}
}
