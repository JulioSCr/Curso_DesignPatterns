using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Conta
	{
		public int Digito { get; set; }
		public long Numero { get; set; }

		public Conta(int digito, long numero)
		{
			Digito = digito;
			Numero = numero;
		}

	}
}
