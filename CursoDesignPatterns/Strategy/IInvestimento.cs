using System;

namespace Strategy
{
	public interface IInvestimento
	{
		decimal Calcula(Conta pContaBancaria);
	}
}
