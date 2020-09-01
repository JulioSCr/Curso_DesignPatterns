using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class PreFixaVisitor : IVisitor
	{
		public void VisitaNumero(Numero pNumero)
		{
			Console.Write(pNumero.Valor);
		}

		public void VisitaSoma(Soma pSoma)
		{
			Console.Write("(");
			Console.Write("+");
			pSoma.Esquerda.Aceita(this);
			Console.Write(" ");
			pSoma.Direita.Aceita(this);
			Console.Write("(");
		}

		public void VisitaSubtracao(Subtracao pSubtracao)
		{
			Console.Write("(");
			Console.Write("-");
			pSubtracao.Esquerda.Aceita(this);
			Console.Write(" ");
			pSubtracao.Direita.Aceita(this);
			Console.Write("(");
		}
	}
}
