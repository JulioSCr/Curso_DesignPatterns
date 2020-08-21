using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class CalculadoraDeImpostos
	{
		public static void RealizaCalculo(Orcamento pOrcamento, IImposto pImposto)
		{
			/// Nesse exemplo, como a CalculadoraDeImpostos apenas exibe um mensagem na tela,
			/// ela não é necessária.Mas agora imagine que, além de calcular o imposto,
			/// essa classe precisasse fazer mais alguma coisa, como por exemplo, alterar o status do Orçamento,
			/// ou notificar algum outro objeto desse valor calculado. Nesse caso, precisaríamos de uma classe para conter essa regra de negócios,
			/// e a classe CalculadoraDeImpostos seria uma boa candidata.

			Console.WriteLine("Valor do imposto {0}", pImposto.Calcular(pOrcamento));
		}
	}
}
