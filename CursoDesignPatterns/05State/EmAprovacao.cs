using System;

namespace State
{
	public class EmAprovacao : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento pOrcamento)
		{
			pOrcamento.Valor = Math.Round(pOrcamento.Valor - (pOrcamento.Valor * 0.05m), 2);
		}

		public void Aprova(Orcamento pOrcamento)
		{
			pOrcamento.Estado = new Aprovado();
		}

		public void Finaliza(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento em aprovação não pode ser finalizado.");
		}

		public void Reprova(Orcamento pOrcamento)
		{
			pOrcamento.Estado = new Reprovado();
		}
	}
}
