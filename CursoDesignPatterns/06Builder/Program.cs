using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Program
	{
		public static void Main(string[] args)
		{
			NotaFiscalBuilder lNotaFiscalBuilder = new NotaFiscalBuilder();
			lNotaFiscalBuilder
				.ParaEmpresa("Unum")
				.ComCNPJ("23.456.789/0001-12")
				.Com(new ItemDaNota("Item 1", 100))
				.Com(new ItemDaNota("Item 2", 50))
				.NaData(new DateTime(2020, 03, 06))
				.ComObservacoes("Uma observação qualquer");

			NotaFiscal lNotaFiscal = lNotaFiscalBuilder.Constroi();

			Console.WriteLine(lNotaFiscal.Text);

			Console.ReadKey();
		}
	}
}

///Um dos problemas da utilização de construtores é que, em casos onde diversos atributos sejam opcionais, 
///precisaríamos ter uma combinação gigante de construtores (uma para cada possível combinação de atributos obrigatórios e opcionais), 
///tornando o código difícil de manter. Além disso, como construir esse objeto é complicado, colocar essa regra no construtor do objeto, 
///só faz com que ele tenha agora mais uma responsabilidade.

///Em outros casos, poderiamos ter diversos ifs dentro do construtor, quanto mais complexo, pode ser mais prático e fácil de manter isolá-lo.

///O Builder possibilita a separação da complexidade da criação desse objeto em uma classe específica para isso, além de possibilitar a 
///implementação de atributos opcionais mais facilmente.

///Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação complicada,
///podemos esconder tudo isso em um Builder.
