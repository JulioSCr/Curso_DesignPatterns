using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class Multiplicador : IAcaoAposGerarNota
	{
		public int Fator { get; private set; }

		public Multiplicador(int pFator)
		{
			Fator = pFator;
		}

		public void Executa(NotaFiscal pNotaFiscal)
		{
			Console.WriteLine($"Valor da nota multiplicado por {Fator}: {pNotaFiscal.ValorBruto * Fator:N}");
		}
	}
}
