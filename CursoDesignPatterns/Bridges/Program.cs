using System;

namespace Bridges
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IMensagem lMensagem = new MensagemAdministrativa("Julio");
			IEnviador lEnviador = new EnviaPorEmail();
			lMensagem.Enviador = lEnviador;
			lMensagem.Envia();
			Console.ReadLine();
		}
	}
}
///Na implementação do bridge que fizemos nesse capítulo, podemos ver que o bridge pode utilizar o strategy em sua implementação: a mensagem
///em seu método Envia utiliza o strategy para decidir qual é a estratégia de envio que será utilizada pela aplicação.
