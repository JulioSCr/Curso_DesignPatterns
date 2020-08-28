using System;

namespace State
{
	public class Finalizado : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento pOrcamento)
		{
			throw new Exception("Orçametos finalizados não recebem desconto extra.");
		}

		public void Aprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está finalizado não pode ser aprovado.");
		}

		public void Finaliza(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está finalizado");
		}

		public void Reprova(Orcamento pOrcamento)
		{
			throw new Exception("Orçamento já está finalizado não pode ser reprovado.");
		}
	}
}
