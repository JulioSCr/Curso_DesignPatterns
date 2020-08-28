using System;

namespace Decorator
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
		public decimal Saldo { get; set; }
		public DateTime DataAbertura { get; set; }

		public void Deposita(decimal pValor)
		{
			this.Saldo += pValor;
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
