using System;
using System.Collections.Generic;

namespace Observer
{
	public class NotaFiscalBuilder
	{
		private string RazaoSocial;
		private string CNPJ;
		private string Observacoes;
		private decimal ValorTotal;
		private decimal Impostos;
		private DateTime Data;
		private IList<ItemDaNota> TodosOsItens = new List<ItemDaNota>();
		private IList<IAcaoAposGerarNota> TodasAcoesAposGerarNota = new List<IAcaoAposGerarNota>();

		public NotaFiscalBuilder()
		{
			Data = DateTime.Now;
		}

		public NotaFiscalBuilder(IList<IAcaoAposGerarNota> pAcoes)
		{
			Data = DateTime.Now;
			TodasAcoesAposGerarNota = pAcoes;
		}

		public NotaFiscalBuilder ParaEmpresa(string pRazaoSocial)
		{
			RazaoSocial = pRazaoSocial;
			return this;
		}

		public NotaFiscalBuilder ComCNPJ(string pCNPJ)
		{
			CNPJ = pCNPJ;
			return this;
		}

		public NotaFiscalBuilder Com(ItemDaNota pItem)
		{
			TodosOsItens.Add(pItem);
			ValorTotal += pItem.Valor;
			Impostos += pItem.Valor * 0.05m;
			return this;
		}

		public NotaFiscalBuilder ComObservacoes(string pObservacoes)
		{
			Observacoes = pObservacoes;
			return this;
		}

		public NotaFiscalBuilder NaData(DateTime pData)
		{
			Data = pData;
			return this;
		}

		public void AdicionaAcao(IAcaoAposGerarNota pAcao)
		{
			TodasAcoesAposGerarNota.Add(pAcao);
		}

		public NotaFiscal Constroi()
		{
			NotaFiscal lNotaFiscal = new NotaFiscal(RazaoSocial, CNPJ, Data, ValorTotal, Impostos, TodosOsItens, Observacoes);

			foreach (IAcaoAposGerarNota lAcao in TodasAcoesAposGerarNota)
			{
				lAcao.Executa(lNotaFiscal);
			}

			return lNotaFiscal;
		}
	}
}
