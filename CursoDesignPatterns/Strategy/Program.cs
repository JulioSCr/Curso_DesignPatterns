using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			///O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em
			///diferentes pedaços da aplicação. No exemplo do vídeo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.
			
			///O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes,
			///e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real"
			///que está sendo executado, e apenas manda o algoritmo rodar.Isso faz com que o código da classe cliente fique bastante desacoplado
			///das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos
			///sem precisar alterar o seu código.

			//TesteImposto();
			TesteInvestimento();
			Console.ReadKey();
		}

		private static void TesteImposto()
		{
			IImposto ICMS = new ICMS();
			IImposto ISS = new ISS();

			Orcamento lOrcamento = new Orcamento(500.00m);
			CalculadoraDeImpostos.RealizaCalculo(lOrcamento, ICMS);
			CalculadoraDeImpostos.RealizaCalculo(lOrcamento, ISS);
		}

		private static void TesteInvestimento()
		{
			IInvestimento pConservador = new Conservador();
			IInvestimento pModerado = new Moderado();
			IInvestimento pArrojado = new Arrojado();

			Conta pContaConservador = new Conta(500);
			Conta pContaModerado = new Conta(500);
			Conta pContaArrojado = new Conta(500);

			Console.WriteLine("Conservador:");
			RealizadorDeInvestimento.RealizarCalculo(pConservador, pContaConservador);
			Console.WriteLine("Moderado:");
			RealizadorDeInvestimento.RealizarCalculo(pModerado, pContaModerado);
			Console.WriteLine("Arrojado:");
			RealizadorDeInvestimento.RealizarCalculo(pArrojado, pContaArrojado);
		}
	}
}
