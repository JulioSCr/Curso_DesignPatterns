using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class Numero : IExpressao
	{
		public Numero(int pInteiro)
		{
			Inteiro = pInteiro;
		}

		public int Inteiro { get; private set; }

		public int Avalia()
		{
			return Inteiro;
		}
	}
}
