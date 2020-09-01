using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class RaizQuadrada : IExpressao
	{
		public RaizQuadrada(IExpressao pExpressao)
		{
			Expressao = pExpressao;
		}

		public IExpressao Expressao { get; private set; }

		public int Avalia()
		{
			int lValor = Expressao.Avalia();
			return (int)Math.Sqrt(lValor);
		}
	}
}
