using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace TemplateMethod
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//TesteImpostoTemplate();
			RelatorioSimples lRelatorioSimples = new RelatorioSimples();
			RelatorioComplexo lRelatorioComplexo = new RelatorioComplexo();

			Conta lConta1 = new Conta();
			Conta lConta2 = new Conta();

			lConta1.Agencia = "1865-8";
			lConta1.Banco = "Banese";
			lConta1.Email = "banese.bank@gmail.com";
			lConta1.Endereco = "Rua Prata Bueno, 1389 Jd Guaruja, São Paulo SP";
			lConta1.Numero = "12354-6";
			lConta1.Saldo = 1712.83m;
			lConta1.Telefone = "(11) 5858-2535";
			lConta1.Titular = "Robson Lewandowski";

			lConta2.Agencia = "3215-4";
			lConta2.Banco = "Banese";
			lConta2.Email = "banese.bank@gmail.com";
			lConta2.Endereco = "Rua Almari Junior, 1006 Jd Luzes, São Paulo SP";
			lConta2.Numero = "01235-6";
			lConta2.Saldo = 123512.83m;
			lConta2.Telefone = "(11) 4694-3214";
			lConta2.Titular = "Rodrigo Klausi Costa";

			lRelatorioSimples.CriarRelatorio(new List<Conta>() { lConta1, lConta2 });
			lRelatorioComplexo.CriarRelatorio(new List<Conta>() { lConta1, lConta2 });

			Console.WriteLine(lRelatorioSimples.Cabecalho.First());
			foreach (var item in lRelatorioSimples.Corpo)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(lRelatorioSimples.Rodape.First());

			Console.WriteLine();
			Console.WriteLine(lRelatorioComplexo.Cabecalho.First());
			foreach (var item in lRelatorioComplexo.Corpo)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(lRelatorioComplexo.Rodape.First());

			Console.ReadKey();
		}

		private static void TesteImpostoTemplate()
		{
			IImposto lIKCV = new IKCV();
			IImposto lICPP = new ICPP();

			IList<Item> lItens = new List<Item>();
			lItens.Add(new Item("Ventilador", 50));
			lItens.Add(new Item("Geladeira", 10000));
			Orcamento lOrcamento = new Orcamento(lItens);

			Console.WriteLine("Orçamento: {0:N}", lOrcamento.Valor);
			Console.WriteLine("Valor do imposto IKCV {0:N}", lIKCV.Calcular(lOrcamento));
			Console.WriteLine("Valor do imposto ICPP {0:N}", lICPP.Calcular(lOrcamento));
		}
	}
}
///Segundo o instrutor o chain of responsibility não trazia melhor performance no problema 02 poderiamos usar o template method lá
///
///Implementar um Template Method ali poderia fazer com que o programador escrevesse menos
///código em todos os nós da corrente, facilitando as novas implementações.
///
///Quando usar:
///Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução.
///Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos",
///que serão implementados de maneira diferente por cada uma das implementações específicas.

///Dessa forma, reutilizamos ao invés de repetirmos código, e facilitamos possíveis evoluções, tanto do algoritmo em sua estrutura macro, 
///quanto dos detalhes do algoritmo, já que cada classe tem sua responsabilidade bem separada.
