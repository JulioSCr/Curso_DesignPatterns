using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class CalculadorDeDescontos
	{
		public static decimal Calcula(Orcamento pOrcamento)
		{
			IDesconto lDescontoPorCincoItens = new DescontoPorCincoItens();
			IDesconto lDescontoPorMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
			IDesconto lDescontoPorVendaCasada = new DescontoPorVendaCasada();
			IDesconto lSemDesconto = new SemDesconto();

			lDescontoPorVendaCasada.Proximo = lDescontoPorCincoItens;
			lDescontoPorCincoItens.Proximo = lDescontoPorMaisDeQuinhentosReais;
			lDescontoPorMaisDeQuinhentosReais.Proximo = lSemDesconto;

			return lDescontoPorCincoItens.Desconta(pOrcamento);
		}
	}
}
