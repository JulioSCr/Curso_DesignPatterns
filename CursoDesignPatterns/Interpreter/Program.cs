using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// (1 + 10) + (20 - 10)
			IExpressao lEsquerda = new Soma(new Numero(1), new Numero(10));
			IExpressao lDireita = new Subtracao(new Numero(20), new Numero(10));
			IExpressao lSoma = new Soma(lEsquerda, lDireita);
			Console.WriteLine(lSoma.Avalia());

			//Com C#
			Expression lSomaC = Expression.Add(Expression.Constant(10), Expression.Constant(100));
			Func<int> lFuncao = Expression.Lambda<Func<int>>(lSomaC).Compile();
			Console.WriteLine(lFuncao());
			
			Console.ReadLine();
		}
	}
}
///O padrão Interpreter é geralmente útil para interpretar DSLs.
///É comum que, ao ler a string (como por exemplo 2+3/4), o programa transforme-a em uma estrutura de dados melhor (como as nossas classes Expressao)
///e aí interprete essa árvore.

///É realmente um padrão de projeto bem peculiar, e com utilização bem específica.
