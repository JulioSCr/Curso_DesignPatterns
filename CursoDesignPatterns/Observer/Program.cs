using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IList<IAcaoAposGerarNota> lAcoes = new List<IAcaoAposGerarNota>();
			lAcoes.Add(new EnviadorDeEmail());
			lAcoes.Add(new NotaFiscalDao());
			lAcoes.Add(new EnviadorDeSms());
			lAcoes.Add(new Multiplicador(5));

			NotaFiscalBuilder lNotaFiscalBuilder = new NotaFiscalBuilder(lAcoes);
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

///Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo,
///podemos implementar o Observer.

///Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações,
///facilitando a manutenção e evolução do código.

