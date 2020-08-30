using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class NotaFiscal
	{
		public string RazaoSocial { get; set; }
		public string CNPJ { get; set; }
		public DateTime DataDeEmissao { get; set; }
		public decimal ValorBruto { get; set; }
		public decimal ValorImposto { get; set; }
		public IList<ItemDaNota> Itens { get; set; }
		public string Observacoes { get; set; }

		public NotaFiscal(string pRazaoSocial,
							string pCNPJ,
							DateTime pDataDeEmissao,
							decimal pValorBruto,
							decimal pValorImposto,
							IList<ItemDaNota> pItens,
							string pObservacoes)
		{
			RazaoSocial = pRazaoSocial;
			CNPJ = pCNPJ;
			DataDeEmissao = pDataDeEmissao;
			ValorBruto = pValorBruto;
			ValorImposto = pValorImposto;
			Itens = pItens;
			Observacoes = pObservacoes;
		}

		public override string ToString()
		{
			return $"Razão Social: {RazaoSocial}\tCNPJ: {CNPJ}\tQuandidade de itens: {Itens.Count}\tData Emissão: {DataDeEmissao:G}";
		}

		public string Text
		{
			get
			{
				return this.ToString();
			}
		}
	}
}
