using System;
using System.Collections.Generic;

namespace State
{
	public class Program
	{
		static void Main(string[] args)
		{
			//TesteOrcamento();

			Conta lConta = new Conta();

			lConta.Deposito(500);
			Console.WriteLine($"{lConta.Saldo:N}");
			lConta.Saque(501);
			Console.WriteLine($"{lConta.Saldo:N}");
			lConta.Deposito(10);
			Console.WriteLine($"{lConta.Saldo:N}");

			Console.ReadLine();
		}

		private static void TesteOrcamento()
		{
			IList<Item> lItens = new List<Item>();
			lItens.Add(new Item("Camiseta", 69.99m));
			Orcamento lOrcamentoKanui = new Orcamento(lItens);

			lOrcamentoKanui.AplicaDescontoExtra();
			Console.WriteLine($"{lOrcamentoKanui.Valor:N}");
			lOrcamentoKanui.Aprova();
			lOrcamentoKanui.AplicaDescontoExtra();
			Console.WriteLine($"{lOrcamentoKanui.Valor:N}");
			lOrcamentoKanui.Finaliza();
		}
	}
}

///A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados.
///Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples.
///O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado
///e saiba controlar as transições.

