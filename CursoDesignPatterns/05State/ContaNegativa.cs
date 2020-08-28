using System;

namespace State
{
	public class ContaNegativa : IEstadoConta
	{
		public decimal Deposito(Conta pConta, decimal pValor)
		{
			return pConta.Saldo + Math.Round(pValor * 0.95m, 2);
		}

		public void Negativa(Conta pConta)
		{
			pConta.Estado = new ContaPositiva();
		}

		public void Positiva(Conta pConta)
		{
			throw new Exception("Esta conta já está positiva.");
		}

		public decimal Saque(Conta pConta, decimal pValor)
		{
			throw new Exception("Conta negativa não pode realizar saque.");
		}
	}
}
