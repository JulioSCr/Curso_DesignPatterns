using System;

namespace State
{
	public class Reprovado : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento pOrcamento)
		{
			throw new Exception("Orçametos reprovados não recebem desconto extra.");
		}

		public void Aprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está reprovado não pode ser aprovado.");
		}

		public void Finaliza(Orcamento pOrcamento)
		{
			pOrcamento.Estado = new Finalizado();
		}

		public void Reprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está reprovado.");
		}
	}
}
