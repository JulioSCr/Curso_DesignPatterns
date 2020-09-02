using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
	public class EnviaPorSms : IEnviador
	{
		public void Envia(IMensagem pMensagem)
		{
			Console.WriteLine("Enviando a mensagem por SMS.");
			Console.WriteLine(pMensagem.Formata());
		}
	}
}
