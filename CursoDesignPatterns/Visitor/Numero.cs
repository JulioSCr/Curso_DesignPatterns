using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Numero : IExpressao
	{
		public Numero(int pInteiro)
		{
			Valor = pInteiro;
		}

		public int Valor { get; private set; }

		public void Aceita(IVisitor pImpressora)
		{
			pImpressora.VisitaNumero(this);
		}

		public int Avalia()
		{
			return Valor;
		}
	}
}
