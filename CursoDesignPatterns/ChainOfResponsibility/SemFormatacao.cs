using System;

namespace ChainOfResponsibility
{
	public class SemFormatacao : IFormatacao
	{
		public IFormatacao Proxima { get; set; }

		public string Formata(Conta pConta, Requisicao pRequisicao)
		{
			return String.Empty;
		}
	}
}
