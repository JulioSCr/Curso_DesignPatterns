using System;

namespace Visitor
{
	public class Soma : IExpressao
	{
		public Soma(IExpressao pEsquerda, IExpressao pDireita)
		{
			Direita = pDireita;
			Esquerda = pEsquerda;
		}

		public IExpressao Direita { get; private set; }
		public IExpressao Esquerda { get; private set; }

		public void Aceita(IVisitor pImpressora)
		{
			pImpressora.VisitaSoma(this);
		}

		public int Avalia()
		{
			int lValorEsquerda = Esquerda.Avalia();
			int lValorDireita = Direita.Avalia();
			return lValorEsquerda + lValorDireita;
		}
	}
}
