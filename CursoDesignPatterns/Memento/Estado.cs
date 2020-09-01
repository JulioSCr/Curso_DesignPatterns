using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class Estado
	{
		public Estado(Contrato pContrato)
		{
			Contrato = pContrato;
		}

		public Contrato Contrato { get; private set; }
	}
}
