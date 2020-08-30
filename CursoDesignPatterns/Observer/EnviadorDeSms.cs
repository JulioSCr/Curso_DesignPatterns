using System;

namespace Observer
{
	public class EnviadorDeSms : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal pNotaFiscal)
		{
			Console.WriteLine("SMS");
		}
	}
}
