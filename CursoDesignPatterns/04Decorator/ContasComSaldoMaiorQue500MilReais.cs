using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ContasComSaldoMaiorQue500MilReais : Filtro
	{
		public ContasComSaldoMaiorQue500MilReais() : base() { }

		public ContasComSaldoMaiorQue500MilReais(Filtro pOutroFiltro) : base(pOutroFiltro) { }

		public override IList<Conta> Filtra(IList<Conta> pContas)
		{
			IList<Conta> lContas = new List<Conta>();
			lContas = pContas.Where(x => x.Saldo > 500000).ToList();
			lContas = (lContas.Concat(FiltraOutroFiltro(pContas).Where(x => !lContas.Contains(x)))).ToList();
			return lContas;
		}
	}
}
