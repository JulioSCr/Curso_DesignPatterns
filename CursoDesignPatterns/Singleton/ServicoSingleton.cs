using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class ServicoSingleton
	{
		private Servico _servico = new Servico();
		public Servico Servico
		{
			get { return _servico; }
		}

	}
}
