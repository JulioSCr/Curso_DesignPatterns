using System;
using System.IO;

namespace State
{
	public class ContaPositiva : IEstadoConta
	{
		public decimal Deposito(Conta pConta, decimal pValor)
		{
			return pConta.Saldo + Math.Round(pValor * 0.98m, 2);
		}

		public void Negativa(Conta pConta)
		{
			pConta.Estado = new ContaNegativa();
		}

		public void Positiva(Conta pConta)
		{
			throw new Exception("Esta conta já está negativada.");
		}

		public decimal Saque(Conta pConta, decimal pValor)
		{
			return pConta.Saldo - pValor;
		}
	}
}
