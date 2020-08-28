using System;

namespace State
{
	public interface IEstadoOrcamento
	{
		void AplicaDescontoExtra(Orcamento pOrcamento);
		void Aprova(Orcamento pOrcamento);
		void Finaliza(Orcamento pOrcamento);
		void Reprova(Orcamento pOrcamento);
	}
}
