using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class RelatorioSimples : RelatorioTemplate
	{
		public override IList<string> Cabecalho { get; protected set; }
		public override IList<string> Corpo { get; protected set; }
		public override IList<string> Rodape { get; protected set; }

		protected override IList<string> PreencherCabecalho(IList<Conta> pContas)
		{
			return new List<string>() { $"Nome do banco: {pContas.First().Banco}" };
		}

		protected override IList<string> PreencherCorpo(IList<Conta> pContas)
		{
			IList<string> lCorpo = new List<string>();
			foreach (Conta pConta in pContas)
			{
				lCorpo.Add($"Titular: {pConta.Titular}\tSaldo: {pConta.Saldo:N}");
			}
			return lCorpo;
		}

		protected override IList<string> PreencherRodape(IList<Conta> pContas)
		{
			return new List<string>() { $"Telefone: { pContas.First().Telefone}" };
		}
	}
}
