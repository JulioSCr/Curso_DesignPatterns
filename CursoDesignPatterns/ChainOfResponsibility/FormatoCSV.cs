using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class FormatoCSV : IFormatacao
	{
		public IFormatacao Proxima { get; set; }

		public string Formata(Conta pConta, Requisicao pRequisicao)
		{
			if (pRequisicao.Formato == EFormato.CSV) return $"{pConta.Numero};{pConta.Digito}";

			return Proxima.Formata(pConta, pRequisicao);
		}
	}
}
