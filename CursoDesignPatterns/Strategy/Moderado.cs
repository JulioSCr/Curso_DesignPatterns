using System;

namespace Strategy
{
	public class Moderado : IInvestimento
	{
		private Random random;
		public Moderado()
		{
			this.random = new Random();
		}

		public decimal Calcula(Conta pConta)
		{
			if (random.Next(2) == 0)
				return pConta.Saldo * 0.025m;
			return pConta.Saldo * 0.007m;
		}
	}
}
