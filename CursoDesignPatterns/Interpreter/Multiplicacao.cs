using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class Multiplicacao : IExpressao
	{
		public Multiplicacao(IExpressao pEsquerda, IExpressao pDireita)
		{
			Direita = pDireita;
			Esquerda = pEsquerda;
		}

		public IExpressao Direita { get; private set; }
		public IExpressao Esquerda { get; private set; }

		public int Avalia()
		{
			int lValorEsquerda = Esquerda.Avalia();
			int lValorDireita = Direita.Avalia();
			return lValorEsquerda * lValorDireita;
		}
	}
}
