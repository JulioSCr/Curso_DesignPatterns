using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class RelatorioComplexo : RelatorioTemplate
	{
		public override IList<string> Cabecalho { get; protected set; }
		public override IList<string> Corpo { get; protected set; }
		public override IList<string> Rodape { get; protected set; }

		protected override IList<string> PreencherCabecalho(IList<Conta> pContas)
		{
			return new List<string>() { $"Nome do banco: {pContas.First().Banco} \t Endereço: {pContas.First().Endereco} \t Telefone: {pContas.First().Telefone}" };
		}

		protected override IList<string> PreencherCorpo(IList<Conta> pContas)
		{
			IList<string> lCorpo = new List<string>();
			foreach (Conta pConta in pContas)
			{
				lCorpo.Add($"Titular: {pConta.Titular}\tAgencia: {pConta.Agencia}\tConta: {pConta.Numero}\tSaldo: {pConta.Saldo:N}");
			}
			return lCorpo;
		}

		protected override IList<string> PreencherRodape(IList<Conta> pContas)
		{
			return new List<string>() { $"E-Mail: {pContas.First().Email}\tData Atual: {DateTime.Now.ToString("G", CultureInfo.GetCultureInfo("pt-br"))}" };
		}
	}
}
