using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class Historico
	{
		private IList<Estado> Estados = new List<Estado>();

		public void Adiciona(Estado pEstado)
		{
			Estados.Add(pEstado);
		}

		public Estado Pega(int pIndice)
		{
			return Estados[pIndice];
		}
	}
}
