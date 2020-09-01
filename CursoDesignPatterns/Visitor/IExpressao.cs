using System;

namespace Visitor
{
	public interface IExpressao
	{
		int Avalia();
		void Aceita(IVisitor pImpressora);
	}
}
