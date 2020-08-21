using System;

namespace Strategy
{
	public class Conservador : IInvestimento
	{
		public decimal Calcula(Conta pConta)
		{
			return pConta.Saldo * 0.008m;
		}
	}
}
