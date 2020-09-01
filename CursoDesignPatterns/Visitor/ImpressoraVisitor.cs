using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class ImpressoraVisitor : IVisitor
	{
		public void VisitaSoma(Soma pSoma)
		{
			Console.Write("(");
			//esquerda
			pSoma.Esquerda.Aceita(this);
			Console.Write("+");
			//direita
			pSoma.Direita.Aceita(this);
			Console.Write(")");
		}

		public void VisitaSubtracao(Subtracao pSubtracao)
		{
			Console.Write("(");
			//esquerda
			pSubtracao.Esquerda.Aceita(this);
			Console.Write("-");
			//direita
			pSubtracao.Direita.Aceita(this);
			Console.Write(")");
		}

		public void VisitaNumero(Numero pNumero)
		{
			Console.Write(pNumero.Valor);
		}
	}
}
