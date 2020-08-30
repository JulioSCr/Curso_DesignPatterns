using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class NotaFiscalDao : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal pNotaFiscal)
		{
			Console.WriteLine("Banco");
		}
	}
}
