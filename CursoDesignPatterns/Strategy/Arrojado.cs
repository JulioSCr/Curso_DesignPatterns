using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class Arrojado : IInvestimento
	{
		private Random random;
		public Arrojado()
		{
			this.random = new Random();
		}

		public decimal Calcula(Conta pConta)
		{
			int lChute = random.Next(101);
			if (lChute <= 20) return pConta.Saldo * 0.05m;
			if (lChute <= 30) return pConta.Saldo * 0.03m;
			return pConta.Saldo * 0.006m;
		}
	}
}
