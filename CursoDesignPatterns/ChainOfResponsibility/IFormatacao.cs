using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public interface IFormatacao
	{
		IFormatacao Proxima { get; set; }
		string Formata(Conta pConta, Requisicao pRequisicao);
	}
}
