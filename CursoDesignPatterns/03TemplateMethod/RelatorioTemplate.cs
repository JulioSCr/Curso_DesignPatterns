using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public abstract class RelatorioTemplate
	{
		public abstract IList<string> Cabecalho { get; protected set; }
		public abstract IList<string> Corpo { get; protected set; }
		public abstract IList<string> Rodape { get; protected set; }

		public void CriarRelatorio(IList<Conta> pContas)
		{
			Cabecalho = PreencherCabecalho(pContas);
			Corpo = PreencherCorpo(pContas);
			Rodape = PreencherRodape(pContas);
		}

		protected abstract IList<string> PreencherCabecalho(IList<Conta> pContas);
		protected abstract IList<string> PreencherCorpo(IList<Conta> pContas);
		protected abstract IList<string> PreencherRodape(IList<Conta> pContas);
	}
}
