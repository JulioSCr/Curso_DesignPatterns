using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ContasComDataDeAberturaNoMesCorrente : Filtro
	{
		public ContasComDataDeAberturaNoMesCorrente() : base() { }

		public ContasComDataDeAberturaNoMesCorrente(Filtro pOutroFiltro) : base(pOutroFiltro) { }

		public override IList<Conta> Filtra(IList<Conta> pContas)
		{
			IList<Conta> lContas = new List<Conta>();
			lContas = pContas.Where(x => x.DataAbertura.Month == DateTime.Now.Month).ToList();
			lContas = (lContas.Concat(FiltraOutroFiltro(pContas).Where(x => !lContas.Contains(x)))).ToList();
			return lContas;
		}
	}
}
