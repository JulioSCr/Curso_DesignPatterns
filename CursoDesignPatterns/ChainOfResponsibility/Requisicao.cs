using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Requisicao
	{
		public EFormato Formato { get; set; }

		public Requisicao(EFormato pFormato)
		{
			Formato = pFormato;
		}
	}
}
