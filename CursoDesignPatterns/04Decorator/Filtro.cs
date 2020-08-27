using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Filtro
	{
		private Filtro OutroFiltro { get; set; }

		public Filtro()
		{
			this.OutroFiltro = null;
		}

		public Filtro(Filtro pOutroFiltro)
		{
			this.OutroFiltro = pOutroFiltro;
		}

		public abstract IList<Conta> Filtra(IList<Conta> pContas);

		protected IList<Conta> FiltraOutroFiltro(IList<Conta> pContas)
		{
			if (OutroFiltro == null) return new List<Conta>();
			return OutroFiltro.Filtra(pContas);
		}
	}
}
