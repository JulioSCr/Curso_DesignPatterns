using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class FormatadorDeConta
	{
		public static void Formata(Conta pConta, Requisicao pRequisicao)
		{
			IFormatacao lFormatoXML = new FormatoXML();
			IFormatacao lFormatoCSV = new FormatoCSV();
			IFormatacao lFormatoPorcento = new FormatoPorcento();
			IFormatacao lSemFormatacao = new SemFormatacao();

			lFormatoXML.Proxima = lFormatoCSV;
			lFormatoCSV.Proxima = lFormatoPorcento;
			lFormatoPorcento.Proxima = lSemFormatacao;

			string lContaFormatada = lFormatoXML.Formata(pConta, pRequisicao);

			Console.WriteLine($"Conta Formatada: {lContaFormatada}");
		}
	}
}
