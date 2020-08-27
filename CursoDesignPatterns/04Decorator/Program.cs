using System;
using System.Collections.Generic;

namespace Decorator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//TesteImposto();

			Filtro lFiltro = new ContasComSaldoMaiorQue500MilReais(new ContasComDataDeAberturaNoMesCorrente());

			Conta lConta1 = new Conta();
			Conta lConta2 = new Conta();
			Conta lConta3 = new Conta();

			lConta1.Agencia = "1865-8";
			lConta1.Banco = "Banese";
			lConta1.Email = "banese.bank@gmail.com";
			lConta1.Endereco = "Rua Prata Bueno, 1389 Jd Guaruja, São Paulo SP";
			lConta1.Numero = "12354-6";
			lConta1.Saldo = 1712.83m;
			lConta1.Telefone = "(11) 5858-2535";
			lConta1.Titular = "Robson Lewandowski";
			lConta1.DataAbertura = new DateTime(2020, 7, 26);

			lConta2.Agencia = "3215-4";
			lConta2.Banco = "Banese";
			lConta2.Email = "banese.bank@gmail.com";
			lConta2.Endereco = "Rua Almari Junior, 1006 Jd Luzes, São Paulo SP";
			lConta2.Numero = "01235-6";
			lConta2.Saldo = 123512.83m;
			lConta2.Telefone = "(11) 4694-3214";
			lConta2.Titular = "Rodrigo Klausi Costa";
			lConta2.DataAbertura = DateTime.Now;

			lConta3.Agencia = "1865-8";
			lConta3.Banco = "Banese";
			lConta3.Email = "banese.bank@gmail.com";
			lConta3.Endereco = "Rua Luis Fernando, 98 Jd Ipanema, São Paulo SP";
			lConta3.Numero = "98431-6";
			lConta3.Saldo = 500354.83m;
			lConta3.Telefone = "(11) 4756-2535";
			lConta3.Titular = "Jose Alcantara Machado";
			lConta3.DataAbertura = new DateTime(2020, 7, 26);

			IList<Conta> lRetorno = lFiltro.Filtra(new List<Conta>() { lConta1, lConta2, lConta3 });
			foreach (Conta lConta in lRetorno)
			{
				Console.WriteLine(lConta.Text);
			}
			Console.ReadKey();

			Console.ReadLine();
		}

		private static void TesteImposto()
		{
			Imposto lISS = new ImpostoMuitoAlto(new ICMS());

			IList<Item> lItens = new List<Item>();
			lItens.Add(new Item("Camiseta", 50));
			Orcamento lOrcamento = new Orcamento(lItens);

			decimal lImposto = lISS.Calcula(lOrcamento);

			Console.WriteLine($"Imposto: {lImposto:N}");
		}
	}
}
///Quando o objeto precisa fazer muita coisa
///Teria que criar uma classe ISSComICMS e assim por diante
///Com o decorator isso não é necessário
///
///Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia,
///como foi o caso dos impostos, que podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição desses comportamentos,
///bastando escolher no momento da instanciação, quais instancias serão utilizadas para realizar o trabalho.
