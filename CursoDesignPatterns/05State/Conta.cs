using System;

namespace State
{
	public class Conta
	{
		public string Banco { get; set; }
		public string Telefone { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public string Titular { get; set; }
		public string Agencia { get; set; }
		public string Numero { get; set; }
		public decimal Saldo { get; private set; }
		public DateTime DataAbertura { get; set; }
		public IEstadoConta Estado { get; set; }

		public Conta()
		{
			Estado = new ContaPositiva();
		}

		public void Saque(decimal pValor)
		{
			Saldo = Estado.Saque(this, pValor);
			if (Saldo < 0 && Estado.GetType() != typeof(ContaNegativa)) Negativa();
		}

		public void Deposito(decimal pValor)
		{
			Saldo = Estado.Deposito(this, pValor);
			if (Saldo > 0 && Estado.GetType() != typeof(ContaPositiva)) Positiva();
		}

		public void Positiva()
		{
			Estado.Positiva(this);
		}

		public void Negativa()
		{
			Estado.Negativa(this);
		}

		public override string ToString()
		{
			return $"Titular: {Titular} | Banco: {Banco} | Data de abertura: {DataAbertura:d} | Saldo {Saldo}";
		}

		public string Text
		{
			get
			{
				return this.ToString();
			}
		}
	}
}
