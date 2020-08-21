using System;

namespace Strategy
{
	public class Conta
	{
		public decimal Saldo { get; private set; }

		public Conta(decimal pValor)
		{
			this.Saldo = pValor;
		}

		public void Deposita(decimal pValor)
		{
			this.Saldo += pValor;
		}
	}
}
