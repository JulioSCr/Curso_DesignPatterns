using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
	public class MensagemCliente : IMensagem
	{
		public MensagemCliente(string pNome)
		{
			Nome = pNome;
		}

		public string Nome { get; private set; }
		public IEnviador Enviador { get; set; }

		public void Envia()
		{
			Enviador.Envia(this);
		}

		public string Formata()
		{
			return $"Enviando a mensagem para o cliente {Nome}";
		}
	}
}
