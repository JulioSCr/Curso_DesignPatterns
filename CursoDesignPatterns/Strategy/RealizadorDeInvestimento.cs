using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class RealizadorDeInvestimento
	{
		public static void RealizarCalculo(IInvestimento pInvestimento, Conta pConta)
		{
			decimal lRendimento = pInvestimento.Calcula(pConta);
			pConta.Deposita(lRendimento);
			Console.WriteLine($"Rendimento: {lRendimento:N2} Novo Saldo: {pConta.Saldo:N2}");
		}
	}
}
