using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class FormatoXML : IFormatacao
	{
		public IFormatacao Proxima { get; set; }

		public string Formata(Conta pConta, Requisicao pRequisicao)
		{
			if (pRequisicao.Formato == EFormato.XML) return $"<conta><numero>{pConta.Numero}</numero><digito>{pConta.Digito}</digito></conta>";

			return Proxima.Formata(pConta, pRequisicao);
		}
	}
}
