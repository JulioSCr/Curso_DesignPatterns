using System;

namespace TemplateMethod
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

		public void Deposita(decimal pValor)
		{
			this.Saldo += pValor;
		}
	}
}
