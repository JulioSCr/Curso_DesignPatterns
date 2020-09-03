using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class FilaDeTrabalho
	{
		private IList<IComando> _comandos = new List<IComando>();
		public IList<IComando> Comandos
		{
			get { return _comandos; }
			private set { _comandos = value; }
		}

		public void Adiciona(IComando pComando)
		{
			Comandos.Add(pComando);
		}

		public void Processa()
		{
			foreach (IComando lComando in Comandos)
			{
				lComando.Executa();
			}
		}
	}
}
