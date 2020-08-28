using System;

namespace State
{
	public class Aprovado : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento pOrcamento)
		{
			pOrcamento.Valor = Math.Round(pOrcamento.Valor - (pOrcamento.Valor * 0.02m), 2);
		}

		public void Aprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está aprovado.");
		}

		public void Finaliza(Orcamento pOrcamento)
		{
			pOrcamento.Estado = new Finalizado();
		}

		public void Reprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está aprovado não pode ser reprovado.");
		}
	}
}
