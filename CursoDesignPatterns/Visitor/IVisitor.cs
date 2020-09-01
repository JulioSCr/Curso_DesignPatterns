using System;

namespace Visitor
{
	public interface IVisitor
	{
		void VisitaSoma(Soma pSoma);
		void VisitaSubtracao(Subtracao pSubtracao);
		void VisitaNumero(Numero pNumero);
	}
}
