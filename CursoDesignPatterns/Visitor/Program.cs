using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
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

			ImpressoraVisitor lImpressora = new ImpressoraVisitor();
			lSoma.Aceita(lImpressora);

			Console.ReadLine();
		}
	}
}
///A finalidade do visitor dentro do código é simplesmente percorrer toda a árvore de expressão para executar alguma lógica.Nesse capítulo,
///ele foi utilizado para imprimir as expressões, mas ele também poderia ser utilizado para realizar cálculos com a expressão ou qualquer outra
///tarefa que dependa do processamento dos nós de nossa árvore de expressão.
