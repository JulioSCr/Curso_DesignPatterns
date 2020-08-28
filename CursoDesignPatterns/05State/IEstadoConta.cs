using System;

namespace State
{
	public interface IEstadoConta
	{
		decimal Saque(Conta pConta, decimal pValor);
		decimal Deposito(Conta pConta, decimal pValor);
		void Positiva(Conta pConta);
		void Negativa(Conta pConta);
	}
}
