using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class EmpresaFacade
	{
		public Cliente BuscaCliente(string pCPF)
		{
			return new ClienteDAO().BuscaPorCpf(pCPF);
		}

		public Fatura CriaFatura(Cliente pCliente, decimal pValor)
		{
			return new Fatura(pCliente, pValor);
		}

		public Cobranca GeraCobranca(Tipo pTipo, Fatura pFatura)
		{
			Cobranca lCobranca = new Cobranca(pTipo, pFatura);
			lCobranca.Emite();
			return lCobranca;
		}

		public ContatoCliente FazContato(Cliente pCliente, Cobranca pCobranca)
		{
			ContatoCliente lContato = new ContatoCliente(pCliente, pCobranca);
			lContato.Dispara();
			return lContato;
		}
	}
}
